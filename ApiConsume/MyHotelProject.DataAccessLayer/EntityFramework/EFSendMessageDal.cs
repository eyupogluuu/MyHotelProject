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
    public class EFSendMessageDal:GenericRepository<SendMessage>,ISendMessageDal
    {
        public EFSendMessageDal(MyHotelContext context) : base(context)
        {

        }
        public int GetSendMessageCount()
        {
            var context = new MyHotelContext();
            return context.SendMessages.Count();
        }
    }
}
