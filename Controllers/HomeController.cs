using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace WebApplication6.Controllers
{
    public class HomeController : Controller
    {

        public ActionResult Page_1()
        {
            return View();
        }

        public ActionResult Page_2()
        {
            return View();
        }

        public ActionResult Page_3()
        {
            return View();
        }
        

        public ActionResult Error()
        {
            Response.StatusCode = 404;
            return View();
        }
        public ActionResult Index()
        {
            return View();
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