using MyHotelProject.BusinessLayer.Abstract;
using MyHotelProject.DataAccessLayer.Abstract;
using MyHotelProject.EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyHotelProject.BusinessLayer.Concrete
{
    public class ContactManager : IContactService
    {
        private readonly IContactDal contactDal;

        public ContactManager(IContactDal contactDal)
        {
            this.contactDal = contactDal;
        }

        public void TDelete(Contact t)
        {
           contactDal.Delete(t);
        }

        public List<Contact> TGetAll()
        {
           return contactDal.GetAll();
        }

        public Contact TGetByID(int id)
        {
            return contactDal.GetByID(id);
        }

        public void TInsert(Contact t)
        {
            contactDal.Insert(t);
        }

        public void TUpdate(Contact t)
        {
            contactDal.Update(t);
        }
    }
}
