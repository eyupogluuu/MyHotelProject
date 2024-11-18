using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyHotelProject.EntityLayer.Concrete
{
    public class SendMessage
    {
        public int sendMessageID { get; set; }
        public string receiverName { get; set; }
        public string receiverMail { get; set; }
        public string senderName { get; set; }
        public string senderMail { get; set; }
        public string title { get; set; }
        public string content { get; set; }
        public DateTime date { get; set; }
    }
}
