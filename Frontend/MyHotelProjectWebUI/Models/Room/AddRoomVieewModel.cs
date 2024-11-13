using System.ComponentModel.DataAnnotations;

namespace MyHotelProjectWebUI.Models.Room
{
    public class AddRoomVieewModel
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
        [Required(ErrorMessage = "Banyo Sayısı Boş Geçilemez")]
        public string wifi { get; set; }
        public string descreption { get; set; }
    }
}
