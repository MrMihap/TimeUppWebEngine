using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Web.Mvc;

namespace TimeUppWebEngine.Models
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

  }

  public class Stat
  {
    [Key]
    public int Id { get; set; }
    public int? StartPointId { get; set; }
    public WayPoint StartPoint { get; set; }
    public int? EndPointId { get; set; }
    public WayPoint EndPoint { get; set; }
    public DateTime RequestDateTime { get; set; }
    public DateTime TimeLength { get; set; }
  }
}