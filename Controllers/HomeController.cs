using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using FootBallLeague;

namespace FootBallLeague.Controllers
{
    public class HomeController : Controller
    {
        FIFAEntities context = new FIFAEntities(); //taken from context class
        public ActionResult Index()
        {

            return View(context.FootBallLeagues.ToList());
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}