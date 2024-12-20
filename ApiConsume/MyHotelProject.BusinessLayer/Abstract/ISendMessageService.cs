﻿using MyHotelProject.EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyHotelProject.BusinessLayer.Abstract
{
    public interface ISendMessageService : IGenericService<SendMessage>
    {
        public int TGetSendMessageCount();
        }
}
