using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using EntityLayer.Concrete;
using MvcProjectCamp.Models;

namespace MvcProjectCamp.Controllers
{
    public class ChartController : Controller
    {
        // GET: Chart
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult CategoryChart()
        {
            return Json(BlogList(), JsonRequestBehavior.AllowGet);
        }

        public List<CategoryClass> BlogList()
        {
            List<CategoryClass> ct = new List<CategoryClass>();

            ct.Add(new CategoryClass()
            {
                CategoryCount = 8,
                CategoryName = "Yazılım"

            });
            ct.Add(new CategoryClass()
            {
                CategoryCount = 5,
                CategoryName = "Seyahat"
            });
            ct.Add(new CategoryClass()
            {
                CategoryCount = 7,
                CategoryName = "Teknoloji"
            });
            ct.Add(new CategoryClass()
            {
                CategoryCount = 2,
                CategoryName = "Spor"
            });
            return ct;
        }
    }
}