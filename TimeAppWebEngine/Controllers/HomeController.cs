using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace TimeAppWebEngine.Controllers
{
  public class HomeController : Controller
  {
    //
    // GET: /Home/

    public ActionResult Index() //about us
    {
      return View();
    }
    public ActionResult Portfolio() 
    {
      return View();
    }
    public ActionResult Team()
    {
      return View();
    }
    public ActionResult Test()
    {
      return View();
    }
  }
}
