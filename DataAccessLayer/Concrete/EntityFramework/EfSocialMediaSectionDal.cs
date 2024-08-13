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
    public class EfSocialMediaSectionDal : GenericRepository<SocialMediaSection>,ISocialMediaSectionDal
    {
        public EfSocialMediaSectionDal(MyPorfolioContext context) : base(context)
        {
        }
    }
}
