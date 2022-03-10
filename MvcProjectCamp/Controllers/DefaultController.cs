using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;

namespace MvcProjectCamp.Controllers
{
    public class DefaultController : Controller
    {
        private HeadingManager hm = new HeadingManager(new EfHeadingDal());
        public ActionResult Headings()
        {
            var headinglist = hm.GetList();
            return View(headinglist);
        }
        public ActionResult Index()
        {
            return View();
        }
    }
}