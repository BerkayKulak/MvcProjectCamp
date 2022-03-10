using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;

namespace MvcProjectCamp.Controllers
{
    public class WriterPanelMessageController : Controller
    {
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
        public PartialViewResult MessageListMenu()
        {
            return PartialView();
        }
    }
}