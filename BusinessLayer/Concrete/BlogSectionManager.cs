using BusinessLayer.Abstract;
using DataAccessLayer.Abstract;
using DataAccessLayer.Concrete.EntityFramework;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Concrete
{
    public class BlogSectionManager : IBlogSectionService
    {
        private readonly IBlogSectionDal _blogSectionDal;

        public BlogSectionManager(IBlogSectionDal blogSectionDal)
        {
            _blogSectionDal = blogSectionDal;
        }

        public void Delete(BlogSection t)
        {
            _blogSectionDal.Delete(t);
        }

        public BlogSection GetById(int id)
        {
            return _blogSectionDal.GetById(id);
        }

        public List<BlogSection> GetListAll()
        {
            return _blogSectionDal.GetListAll();
        }

        public void Insert(BlogSection t)
        {
            _blogSectionDal.Insert(t);
        }

        public void Update(BlogSection t)
        {
            _blogSectionDal.Update(t);
        }
    }
}
