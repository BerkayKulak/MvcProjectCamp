using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using EntityLayer.Concrete;

namespace MvcProjectCamp.Controllers
{
    public class AuthorizationController : Controller
    {
        private AdminManager admin = new AdminManager(new EfAdminDal());
        public ActionResult Index()
        {
            var adminValues = admin.GetList();
            return View(adminValues);
        }

        [HttpGet]
        public ActionResult AddAdmin()
        {
            return View();
        }

        [HttpPost]
        public ActionResult AddAdmin(Admin p)
        {
            admin.AdminAddBL(p);
            return RedirectToAction("Index");
        }

        [HttpGet]
        public ActionResult EditAdmin(int id)
        {
            var adminValue = admin.GetById(id);
            return View(adminValue);

        }

        [HttpPost]
        public ActionResult EditAdmin(Admin p)
        {
            admin.AdminUpdate(p);
            return RedirectToAction("Index");
        }
    }
}