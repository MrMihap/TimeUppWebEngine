using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using TimeUppWebEngine.Models;
namespace TimeUppWebEngine.Controllers
{
  public class HomeController : Controller
  {
    //
    // GET: /Home/

    public ActionResult Index()
    {
      using (AppContext _db = new AppContext())
      {
        //return Content("<p>" + "<p>");
      }
      return View();
    }
    

  }
}
