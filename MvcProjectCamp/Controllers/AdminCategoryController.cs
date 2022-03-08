using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.UI.WebControls;
using BusinessLayer.Concrete;
using BusinessLayer.ValidationRules;
using DataAccessLayer.EntityFramework;
using EntityLayer.Concrete;
using FluentValidation.Results;

namespace MvcProjectCamp.Controllers
{
    public class AdminCategoryController:Controller
    {
        private CategoryManager cm = new CategoryManager(new EfCategoryDal());

        public ActionResult Index()
        {
            var categoryValues = cm.GetList();
            return View(categoryValues);
        }

        [HttpGet]
        public ActionResult AddCategory()
        {
            return View();
        }

        [HttpPost]
        public ActionResult AddCategory(Category p)
        {
            CategoryValidatior categoryValidatior = new CategoryValidatior();

            ValidationResult results = categoryValidatior.Validate(p);

            if (results.IsValid)
            {
                cm.CategoryAddBL(p);

                return RedirectToAction("Index");
            }
            else
            {
                foreach (var item in results.Errors)
                {
                    ModelState.AddModelError(item.PropertyName,item.ErrorMessage);
                }
            }
            return View();
        }

        public ActionResult DeleteCategory(int id)
        {
            var categoryValue = cm.GetById(id);

            cm.CategoryDelete(categoryValue);

            return RedirectToAction("Index");
        }
    }
}