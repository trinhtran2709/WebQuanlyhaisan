using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace DoAn.Controllers
{
    public class DoAnController : Controller
    {
        // GET: DoAn
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult HeaderPartial()
        {
            return PartialView();
        }
        public ActionResult NavPartial()
        {
            return PartialView();
        }
        public ActionResult SliderPartial()
        {
            return PartialView();
        }
        public ActionResult FooterPartial()
        {
            return PartialView();
        }
        public ActionResult HaisanbanchayPartial()
        {
            return PartialView();
        }



    }
}