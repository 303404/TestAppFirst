using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace TESTDelete.Controllers
{
    [RouteArea("")]
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page3333.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
        [Route("Hello/{id :int}")]
        public ActionResult GetName(int id)
        {
            return null;
        }
        public ActionResult GetNamee()
        {
            return View();
        }
        public ActionResult CheckCountValue(int i)
        {
            if (i < 20)
            {
                //business logic goes here  
            }
            else
            {
                throw (new Exception("Out of the Range"));
            }

            return View();
        }
    }
}