using BusinessLayer.Abstract;
using DataAccessLayer.Abstract;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Concrete
{
    public class ContactSectionManager : IContactSectionService
    {
        private readonly IContactSectionDal _contactSectionDal;

        public ContactSectionManager(IContactSectionDal contactSectionDal)
        {
            _contactSectionDal = contactSectionDal;
        }

        public void Delete(ContactSection t)
        {
            _contactSectionDal.Delete(t);
        }

        public ContactSection GetById(int id)
        {
            return _contactSectionDal.GetById(id);
        }

        public List<ContactSection> GetListAll()
        {
            return _contactSectionDal.GetListAll();
        }

        public void Insert(ContactSection t)
        {
            _contactSectionDal.Insert(t);
        }

        public void Update(ContactSection t)
        {
            _contactSectionDal.Update(t);
        }
    }
}
