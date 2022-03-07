﻿using DataAccessLayer.Concrete.Repositories;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BusinessLayer.Abstract;
using DataAccessLayer.Abstract;

namespace BusinessLayer.Concrete
{
    public class CategoryManager:ICategoryService
    {

        private ICategoryDal _categoryDal;

        public CategoryManager(ICategoryDal categoryDal)
        {
            _categoryDal = categoryDal;
        }

        public List<Category> GetList()
        {
            return _categoryDal.List();
        }

        public void CategoryAddBL(Category p)
        {
            if (p.CategoryName == "" || p.CategoryStatus == false || p.CategoryName.Length <= 2)
            {

            }
            else
            {
                _categoryDal.Insert(p);
            }
        }

    }
}
