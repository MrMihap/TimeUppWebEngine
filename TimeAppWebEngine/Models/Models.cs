using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TimeAppWebEngine.Models
{
  public class AlarmTimeLine
  {
    private Task alarm;
    private List<Stat> statList;
    public double Average = 0;
    public double Delta = 0;
    public AlarmTimeLine(){}
    public AlarmTimeLine(AlarmID alarmID)
    {
      using (AppContext _db = new AppContext())
      {
        if (_db.Tasks.Where(task => task.Id == alarmID.id).Count() != 1)
        {
          throw new ArgumentException("Task not exist or have dublicate");
        }
        alarm = (from t in _db.Tasks where t.Id.Equals(alarmID.id) select t).FirstOrDefault();
        statList = (_db.Stats.Where(s => s.AlarmId == alarmID.id)).ToList();
      }
    }
    public void Calc()
    {
      Average = 0;
      Delta = 0;
      DateTime Last = statList.Last().RequestDateTime;
      int Count = (from x in statList where (Last - x.RequestDateTime).TotalMinutes <= 60 select x.WayDuration).Count();
      if (Count <= 1)
        throw new ArgumentException("To low stat elements");
      Average = (from x in statList where (Last - x.RequestDateTime).TotalMinutes <= 60 select x.WayDuration).Sum();
      List<int> laststat = (from x in statList where (Last - x.RequestDateTime).TotalMinutes <= 60 select x.WayDuration).ToList();
      Average /= Count;
      for(int i = 0; i < Count; i++)
      {
        Delta += Math.Pow(laststat[i] - Average, 2);
      }
      Delta /= Count + 1;
      Delta = Math.Sqrt(Delta);
    }

  }
}