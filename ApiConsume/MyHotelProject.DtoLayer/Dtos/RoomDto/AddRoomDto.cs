using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyHotelProject.DtoLayer.Dtos.RoomDto
{
    public class AddRoomDto
    {
        [Required(ErrorMessage ="Oda Numarası Boş Geçilemez")]
        public string roomNumber { get; set; }
        public string tittle { get; set; }
        [Required(ErrorMessage = "Fiyat Bilgisi Boş Geçilemez")]
        public int price { get; set; }
        [Required(ErrorMessage = "Yatak Sayısı Boş Geçilemez")]
        public string bedCount { get; set; }
        [Required(ErrorMessage = "Banyo Sayısı Boş Geçilemez")]
        public string bathCount { get; set; }
        [Required(ErrorMessage = "Wifi Bilgisi Boş Geçilemez")]
        public string wifi { get; set; }
        public string descreption { get; set; }
    }
}
