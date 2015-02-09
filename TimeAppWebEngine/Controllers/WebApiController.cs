using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using TimeAppWebEngine.Models;
using System.Data.Entity;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
namespace TimeAppWebEngine.Controllers
{
  public class WebApiController : Controller
  {
    //
    // GET: /Api/

    [HttpGet]
    public ActionResult Index()
    {
      using (AppContext _db = new AppContext())
      {

      }
      return View();
    }
    [HttpPost]
    public JsonResult Index(string json)
    {
      using (AppContext _db = new AppContext())
      {

      }
      return Json(new { Messsage = "Hello, it's Time Upp web api server" }, JsonRequestBehavior.AllowGet);
    }
    public JsonResult RegisterAlarm(string JsonString)
    {
      //parsing
      RegAlarm alarm;
      try
      {
        JsonString = Request["json"];

        alarm = JsonConvert.DeserializeObject<RegAlarm>(JsonString, new IsoDateTimeConverter());
        Task task = new Task(alarm);
        using (AppContext _db = new AppContext())
        {
          _db.Tasks.Add(task);
          _db.SaveChanges();
          return Json(new { ResultCode = "1", ErrorCode = "0", AlarmID = task.Id.ToString() }, JsonRequestBehavior.AllowGet);
        }
      }
      catch (JsonException e)
      {
        return Json(new { ResultCode = "0", ErrorCode = "1", ErrorProp = e.Message.ToString() }, JsonRequestBehavior.AllowGet);
      }
      catch (System.Data.Entity.Infrastructure.DbUpdateException e)
      {
        return Json(new { ResultCode = "0", ErrorCode = "1", ErrorProp = e.Message.ToString() }, JsonRequestBehavior.AllowGet);
      }
      catch (Exception e)
      {
        return Json(new { ResultCode = "0", ErrorCode = "1", ErrorProp = e.Message.ToString() }, JsonRequestBehavior.AllowGet);
      }
      return Json(new { ResultCode = "0", ErrorCode = "1" }, JsonRequestBehavior.AllowGet);
    }
    public JsonResult SetAlarmDuration(string JsonString)
    {
      //parsing
      JsonString = Request["json"];
      AlarmDuration alarmDuration = JsonConvert.DeserializeObject<AlarmDuration>(JsonString);
      //Проверяем корректность по пользователю
      try
      {
        Stat durationStat = new Stat(alarmDuration);
        using (AppContext _db = new AppContext())
        {
          _db.Stats.Add(durationStat);
          _db.SaveChanges();
        }
      }
      catch (System.Data.Entity.Infrastructure.DbUpdateException e)
      {
        return Json(new { ResultCode = "0", ErrorCode = "1", ErrorProp = e.Message.ToString() }, JsonRequestBehavior.AllowGet);
      }
      catch (Exception e)
      {
        return Json(new { ResultCode = "0", ErrorCode = "1", ErrorProp = e.Message.ToString() }, JsonRequestBehavior.AllowGet);
      }
      return Json(new { ResultCode = "1", ErrorCode = "0" }, JsonRequestBehavior.AllowGet);
    }
    public String GetAlarmTimeLine(string JsonString)
    {
      JsonString = Request["json"];
      AlarmID alarmID = JsonConvert.DeserializeObject<AlarmID>(JsonString);
      try
      {
        AlarmTimeLine timeLine = new AlarmTimeLine(alarmID);

        timeLine.Calc();
        AlarmTimeLineResponce responce = new AlarmTimeLineResponce(timeLine);
        return JsonConvert.SerializeObject(responce);
      }
      catch (Exception e)
      {
        return Json(new { ResultCode = "0", ErrorCode = "1", ErrorProp = e.Message.ToString() }, JsonRequestBehavior.AllowGet).ToString();
      }
    }
  }
}
