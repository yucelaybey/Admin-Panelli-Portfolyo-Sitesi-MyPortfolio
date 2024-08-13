using DataAccessLayer.Abstract;
using DataAccessLayer.Concrete.Repositories;
using DataAccessLayer.Contexts;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Concrete.EntityFramework
{
    public class EfAboutSectionDal : GenericRepository<AboutSection> ,IAboutSectionDal
    {
        public EfAboutSectionDal(MyPorfolioContext context) : base(context)
        {
        }
    }
}
