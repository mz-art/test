using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Test.Controllers {
    [RoutePrefix("")]
    public class HomeController : Controller {
        [Route("")]
        public ActionResult Index() {
            return View();
        }

        [Route("about")]
        public ActionResult About() {
            ViewBag.Message = "깃허브테스트중";

            return View();
        }

        [Route("contact")]
        public ActionResult Contact() {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}