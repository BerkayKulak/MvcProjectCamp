using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using BusinessLayer.Concrete;
using DataAccessLayer.Concrete;
using DataAccessLayer.EntityFramework;

namespace MvcProjectCamp.Controllers
{
    public class WriterPanelContentController : Controller
    {
        private ContentManager cm = new ContentManager(new EfContentDal());
        public ActionResult MyContent(string p)
        {
            Context c = new Context();

            p = (string) Session["WriterMail"];

            var writeridinfo = c.Writers.Where(x => x.WriterMail == p).Select(y=>y.WriterId).FirstOrDefault();

            var contentValues = cm.GetListByWriter(writeridinfo);

            return View(contentValues);
        }
    }
}