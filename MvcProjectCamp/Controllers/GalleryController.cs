﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;

namespace MvcProjectCamp.Controllers
{
    public class GalleryController : Controller
    {
        // GET: Gallery
        private ImageFileManager _imageFileManager = new ImageFileManager(new EfImageFileDal());
        public ActionResult Index()
        {
            var files = _imageFileManager.GetList();
            return View(files);
        }
    }
}