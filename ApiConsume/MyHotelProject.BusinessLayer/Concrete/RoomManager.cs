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
    public class RoomManager : IRoomService
    {
        private readonly IRoomDal roomDal;

        public RoomManager(IRoomDal roomDal)
        {
            this.roomDal = roomDal;
        }

        public void TDelete(Room t)
        {
            roomDal.Delete(t);
        }

        public List<Room> TGetAll()
        {
            return roomDal.GetAll();
        }

        public Room TGetByID(int id)
        {
            return roomDal.GetByID(id);
        }

        public void TInsert(Room t)
        {
            roomDal.Insert(t);
        }

        public int TRoomCount()
        {
           return roomDal.RoomCount();
        }

        public void TUpdate(Room t)
        {
           roomDal.Update(t);
        }
    }
}
