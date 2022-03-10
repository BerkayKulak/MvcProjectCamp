using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;

namespace MvcProjectCamp.Controllers
{
    public class WriterPanelContentController : Controller
    {
        private ContentManager cm = new ContentManager(new EfContentDal());
        public ActionResult MyContent()
        {
            var contentValues = cm.GetListByWriter();
            return View(contentValues);
        }
    }
}