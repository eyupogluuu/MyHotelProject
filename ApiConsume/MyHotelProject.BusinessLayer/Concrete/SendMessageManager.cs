using MyHotelProject.BusinessLayer.Abstract;
using MyHotelProject.DataAccessLayer.Abstract;
using MyHotelProject.EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;

namespace MyHotelProject.BusinessLayer.Concrete
{
    public class SendMessageManager : ISendMessageService
    {
        private readonly ISendMessageDal sendMessageDal;

        public SendMessageManager(ISendMessageDal sendMessageDal)
        {
            this.sendMessageDal = sendMessageDal;
        }

        public void TDelete(SendMessage t)
        {
            sendMessageDal.Delete(t);
        }

        public List<SendMessage> TGetAll()
        {
            return sendMessageDal.GetAll();
        }

        public SendMessage TGetByID(int id)
        {
            return sendMessageDal.GetByID(id);
        }

        public int TGetSendMessageCount()
        {
           return sendMessageDal.GetSendMessageCount();
        }

        public void TInsert(SendMessage t)
        {
             sendMessageDal.Insert(t);
        }

        public void TUpdate(SendMessage t)
        {
            sendMessageDal.Update(t);
        }
    }
}
