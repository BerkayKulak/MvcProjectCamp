using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BusinessLayer.Abstract;
using DataAccessLayer.Abstract;
using EntityLayer.Concrete;

namespace BusinessLayer.Concrete
{
    public class AboutManager:IAboutService
    {
        private IAboutDal _aboutDal;
        public List<About> GetList()
        {
            throw new NotImplementedException();
        }

        public void AboutAddBL(About category)
        {
            throw new NotImplementedException();
        }

        public About GetById(int id)
        {
            throw new NotImplementedException();
        }

        public void AboutDelete(About category)
        {
            throw new NotImplementedException();
        }

        public void AboutUpdate(About category)
        {
            throw new NotImplementedException();
        }
    }
}
