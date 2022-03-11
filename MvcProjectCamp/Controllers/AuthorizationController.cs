using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;

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
    }
}