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


        public void CategoryAddBL(Category category)
        {
            _categoryDal.Insert(category);
        }

        public Category GetById(int id)
        {
            return _categoryDal.Get(x => x.CategoryId == id);
        }

        public void CategoryDelete(Category category)
        {
            _categoryDal.Delete(category);
        }
    }
}
