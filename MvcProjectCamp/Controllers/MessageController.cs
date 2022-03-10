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
    public class MessageController : Controller
    {
        // GET: Message
        private MessageManager mm = new MessageManager(new EfMessageDal());

        public ActionResult Inbox()
        {
            var messageList = mm.GetListInbox();
            return View(messageList);
        }

        public ActionResult Sendbox()
        {
            var messageList = mm.GetListSendbox();
            return View(messageList);
        }


        public ActionResult GetInBoxMessageDetails(int id)
        {
            var values = mm.GetById(id);

            return View(values);
        }

        public ActionResult GetSendBoxMessageDetails(int id)
        {
            var values = mm.GetById(id);

            return View(values);
        }

        [HttpGet]
        public ActionResult NewMessage()
        {
            
            return View();
        }

        [HttpPost]
        public ActionResult NewMessage(Message p)
        {
            p.MessageDate = DateTime.Parse(DateTime.Now.ToShortDateString());
            mm.MessageAddBL(p);
            return RedirectToAction("Sendbox");
        }
    }
}