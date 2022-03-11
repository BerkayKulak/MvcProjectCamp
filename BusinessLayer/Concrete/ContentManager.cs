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
    public class ContentManager:IContentService
    {
        private IContentDal _contentDal;

        public ContentManager(IContentDal contentDal)
        {
            _contentDal = contentDal;
        }

        public List<Content> GetList(string p)
        {
            return _contentDal.List(x=>x.ContentValue.Contains(p));
        }

        public void ContentAddBL(Content category)
        {
            _contentDal.Insert(category);
        }

        public Content GetById(int id)
        {
            throw new NotImplementedException();
        }

        public void ContentDelete(Content category)
        {
            throw new NotImplementedException();
        }

        public void ContentUpdate(Content category)
        {
            throw new NotImplementedException();
        }

        public List<Content> GetListByHeadingId(int id)
        {
            return _contentDal.List(x => x.HeadingId == id);
        }

        public List<Content> GetListByWriter(int id)
        {
            return _contentDal.List(x => x.WriterId == id);
        }

        
    }
}
