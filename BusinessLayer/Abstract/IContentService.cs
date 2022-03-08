using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EntityLayer.Concrete;

namespace BusinessLayer.Abstract
{
    public interface IContentService
    {
        List<Content> GetList();
        List<Content> GetListByHeadingId(int id);
        void ContentAddBL(Content category);
        Content GetById(int id);
        void ContentDelete(Content category);
        void ContentUpdate(Content category);
    }
}
