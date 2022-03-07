using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAccessLayer.Abstract;
using EntityLayer.Concrete;

namespace DataAccessLayer.Concrete.Repositories
{
    public class CategoryRepository:ICategoryDal
    {
        private Context c = new Context();
        private DbSet<Category> _object;
        public List<Category> List()
        {
            return _object.ToList();
        }

        public void Insert(Category p)
        {
            _object.Add(p);
            c.SaveChanges();
        }

        public void Update(Category p)
        {
            c.SaveChanges();
        }

        public void Delete(Category p)
        {
            _object.Remove(p);
            c.SaveChanges();
        }
    }
}
