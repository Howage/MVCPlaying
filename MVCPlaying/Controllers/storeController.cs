using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVCPlaying.Controllers
{
    public class storeController : Controller
    {
       public ActionResult Index()
        {
            return View();
        }
        public string Welcome()
        {
            return "This is the Welcome Action Method...";
        }
        // GET: store
       
        public ActionResult about()
        {
            return View();
        }
    }
}