using System.ComponentModel.DataAnnotations;

namespace MyHotelProjectWebUI.Models.AppUser
{
    public class LoginUserViewModel
    {
        [Required(ErrorMessage ="Bu Alan Boş Geçilemez")]
        public string username { get; set; }
        [Required(ErrorMessage = "Bu Alan Boş Geçilemez")]
        public string password { get; set; }
    }
}
