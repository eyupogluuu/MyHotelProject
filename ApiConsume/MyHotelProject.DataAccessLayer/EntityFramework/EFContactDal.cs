﻿using MyHotelProject.DataAccessLayer.Abstract;
using MyHotelProject.DataAccessLayer.Concrete;
using MyHotelProject.DataAccessLayer.Repositories;
using MyHotelProject.EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyHotelProject.DataAccessLayer.EntityFramework
{
    public class EFContactDal:GenericRepository<Contact>,IContactDal
    {
        public EFContactDal(MyHotelContext context) : base(context)
        {

        }
        public int GetContactCount()
        {
            var context = new MyHotelContext();
            return context.Contacts.Count();
        }
    }
}
