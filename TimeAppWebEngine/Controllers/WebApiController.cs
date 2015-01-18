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
        UserAccount acc = new UserAccount();
        acc.EMail = "test@test";
        _db.UserAccounts.Add(acc);
        _db.SaveChanges();
        int i = _db.UserAccounts.Count();
      }
      return View();
    }
    [HttpPost]
    public JsonResult Index(string json)
    {
      using (AppContext _db = new AppContext())
      {
        UserAccount acc = new UserAccount();
        acc.EMail = "test@test";
        _db.UserAccounts.Add(acc);
        _db.SaveChanges();
        int i = _db.UserAccounts.Count();
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
        using (AppContext _db = new AppContext())
        {
          Task task = new Task(alarm);
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
      RegAlarm alarm = JsonConvert.DeserializeObject<RegAlarm>(JsonString);

      return Json(new { ResultCode = "0", ErrorCode = "1" }, JsonRequestBehavior.AllowGet);
    }

  }
}
