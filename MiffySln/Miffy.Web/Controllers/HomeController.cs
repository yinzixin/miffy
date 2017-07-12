using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Miffy.Web.Common;
using Miffy.Model;
using Miffy.Data;

namespace Miffy.Web.Controllers
{
    public class HomeController : Controller
    {
        [DomainTranslateAttribute]
        public ActionResult Index()
        {
            var user =(User)Session["user_page"];

            return View();
        }

        public ActionResult About()
        {
            
            ViewBag.Message =  Request.Url.Host;

            return View();
        } 

        public ActionResult Content(string id)
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}