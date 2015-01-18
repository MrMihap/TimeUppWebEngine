using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Newtonsoft.Json;

namespace TimeUppWebEngine.Controllers
{
  public class WebApiController : Controller
  {
    //
    // GET: /WebApi/
    [HttpGet]
    public ActionResult Index()
    {
      return Content("Hello, it's API");
    }
    [HttpPost]
    public JsonResult Index(string json)
    {
      return Json(new { Messsage = "Hello, it's Time Upp web api server"}, JsonRequestBehavior.AllowGet);
    }
    public JsonResult RegisterAlarm(string JsonString)
    {
      //parsing

      return Json(new { ResultCode = "0", ErrorCode = "1" }, JsonRequestBehavior.AllowGet);
    }
    public JsonResult SetAlarmDuration(string JsonString)
    {
      return Json(new { ResultCode = "0", ErrorCode = "1" }, JsonRequestBehavior.AllowGet);
    }
  }
}
