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
    public class EFRoomDal:GenericRepository<Room>,IRoomDal
    {
        public EFRoomDal(MyHotelContext context):base(context)
        {
                
        }
        public int RoomCount()
        {
            var context = new MyHotelContext();
            var value = context.Rooms.Count();
            return value;
        }
    }
}
