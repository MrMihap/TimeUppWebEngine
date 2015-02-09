using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Web.Mvc;

namespace TimeAppWebEngine.Models
{
  public class AppContext : DbContext
  {
    public DbSet<UserAccount> UserAccounts { get; set; }
    public DbSet<WayPoint> WayPoints { get; set; }
    public DbSet<Task> Tasks { get; set; }
    public DbSet<Stat> Stats { get; set; }
  }

  public class UserAccount
  {
    [Key]
    public int Id { get; set; }
    public string EMail { get; set; }
  }


  public class WayPoint
  {
    [Key]
    public int Id { get; set; }
    public double x { get; set; }
    public double y { get; set; }
    public WayPoint(Location loc)
    {
      this.x = loc.X;
      this.y = loc.Y;
    }
    public override bool Equals(object obj)
    {
      if (obj is Location)
      {
        Location location = obj as Location;
        if (location.X == x && location.Y == y)
          return true;
        else
          return false;
      }
      return base.Equals(obj);
    }
    public override int GetHashCode()
    {
      return (int)x * 100 + (int)y;
      //return base.GetHashCode();
    }
  }

  public class Task
  {
    [Key]
    public int Id { get; set; }
    public int? userId { get; set; }
    public UserAccount userAccount { get; set; }
    public string Name { get; set; }
    public int? StartPointId { get; set; }
    public WayPoint StartPoint { get; set; }
    public int? EndPointId { get; set; }
    public WayPoint EndPoint { get; set; }
    public DateTime DestinationTime { get; set; }
    public Task()
    {
    }
    public Task(RegAlarm alarm)
    {
      using (AppContext _db = new AppContext())
      {
        //int User = (from user in _db.UserAccounts where user.EMail.Equals(alarm.UserID) select user).Count();
        UserAccount acc = new UserAccount();
        int User = _db.UserAccounts.Where((user) => user.EMail.Equals(alarm.UserID)).Count();
        if (User == 0)
        {
          acc.EMail = alarm.UserID;
          _db.UserAccounts.Add(acc);
        }
        else
        {
          acc = _db.UserAccounts.Where((user) => user.EMail.Equals(alarm.UserID)).FirstOrDefault();
        }
        WayPoint point = new WayPoint(alarm.Location);
        _db.WayPoints.Add(point);
        _db.SaveChanges();
        this.StartPointId = point.Id;
        this.userId = acc.Id;
        this.DestinationTime = alarm.ArrivalTime;
        this.EndPointId = point.Id;
        this.Name = "";

      }
    }
  }

  public class Stat
  {
    [Key]
    public int Id { get; set; }
    public int? StartPointId { get; set; }
    public WayPoint StartPoint { get; set; }
    public int? EndPointId { get; set; }
    public WayPoint EndPoint { get; set; }
    public int? AlarmId { get; set; }
    public Task Alarm { get; set; }
    public DateTime RequestDateTime { get; set; }
    public int WayDuration { get; set; }

    public Stat()
    {
    }

    public Stat(AlarmDuration duration)
    {
      //chek for userID, etc
      using (AppContext _db = new AppContext())
      {
        if (_db.UserAccounts.Where(acc => acc.EMail.Equals(duration.UserID)).Count() != 1)
        {
          throw new ArgumentException("User not exist or have dublicate");
        }
        if (_db.Tasks.Where(task => task.Id == duration.AlarmID).Count() != 1)
        {
          throw new ArgumentException("Task not exist or have dublicate");
        }
        int UserID = _db.UserAccounts.Where(acc => acc.EMail.Equals(duration.UserID)).FirstOrDefault().Id;
        Task currentTask = _db.Tasks.Where(task => task.Id == duration.AlarmID).FirstOrDefault();
        if (UserID != currentTask.userId)
        {
          throw new ArgumentException("UserID Mismatch");
        }
        this.EndPointId = currentTask.EndPointId;
        this.RequestDateTime = duration.Time;
        this.WayDuration = duration.Duration;
        this.AlarmId = duration.AlarmID;
        WayPoint point = new WayPoint(duration.location);
        _db.WayPoints.Add(point);
        _db.SaveChanges();
        this.StartPointId = point.Id;

        
      }
    }
  }
}