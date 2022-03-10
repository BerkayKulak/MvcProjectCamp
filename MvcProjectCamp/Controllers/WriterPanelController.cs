using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using BusinessLayer.Concrete;
using DataAccessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using EntityLayer.Concrete;

namespace MvcProjectCamp.Controllers
{
    public class WriterPanelController : Controller
    {
        private HeadingManager hm = new HeadingManager(new EfHeadingDal());

        CategoryManager cm = new CategoryManager(new EfCategoryDal());

        WriterManager wm = new WriterManager(new EfWriterDal());

        Context c = new Context();



        public ActionResult WriterProfile()
        {
            return View();
        }

        public ActionResult MyHeading(string p)
        {
           

            p = (string) Session["WriterMail"];

            var writeridInfo = c.Writers.Where(x => x.WriterMail == p).Select(y=>y.WriterId).FirstOrDefault();

            var values = hm.GetListByWriter(writeridInfo);

            return View(values);
        }

        [HttpGet]
        public ActionResult NewHeading()
        {
            List<SelectListItem> valueCategory = (from x in cm.GetList()
                                                  select new SelectListItem
                                                  {
                                                      Text = x.CategoryName,
                                                      Value = x.CategoryId.ToString()
                                                  }).ToList();

            ViewBag.vlc = valueCategory;

            return View();
        }
        [HttpPost]
        public ActionResult NewHeading(Heading p)
        {
            string writerMailInfo = (string)Session["WriterMail"];

            var writeridInfo = c.Writers.Where(x => x.WriterMail == writerMailInfo).Select(y => y.WriterId).FirstOrDefault();

            p.HeadingDate = DateTime.Parse(DateTime.Now.ToShortDateString());

            p.WriterId = writeridInfo;

            p.HeadingStatus = true;

            hm.HeadingAddBL(p);

            return RedirectToAction("MyHeading");
        }


        public ActionResult EditHeading(int id)
        {
            List<SelectListItem> valueCategory = (from x in cm.GetList()
                                                  select new SelectListItem
                                                  {
                                                      Text = x.CategoryName,
                                                      Value = x.CategoryId.ToString()
                                                  }).ToList();

            ViewBag.vlc = valueCategory;

            var HeadingValue = hm.GetById(id);

            return View(HeadingValue);
        }

        [HttpPost]
        public ActionResult EditHeading(Heading p)
        {
            hm.HeadingUpdate(p);

            return RedirectToAction("MyHeading");
        }

        public ActionResult DeleteHeading(int id)
        {
            var HeadingValue = hm.GetById(id);
            HeadingValue.HeadingStatus = false;
            hm.HeadingDelete(HeadingValue);
            return RedirectToAction("MyHeading");
        }

        public ActionResult AllHeading()
        {
            var heading = hm.GetList();
            return View(heading);
        }
    }
}