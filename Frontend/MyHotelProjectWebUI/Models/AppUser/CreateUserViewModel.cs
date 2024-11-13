using System.ComponentModel.DataAnnotations;

namespace MyHotelProjectWebUI.Models.AppUser
{
    public class CreateUserViewModel
    {
        [Required(ErrorMessage ="Bu Alan Boş Geçilemez")]
        public string name { get; set; }
        [Required(ErrorMessage = "Bu Alan Boş Geçilemez")]
        public string surname { get; set; }
        [Required(ErrorMessage = "Bu Alan Boş Geçilemez")]
        public string username { get; set; }
        [Required(ErrorMessage = "Bu Alan Boş Geçilemez")]
        public string mail { get; set; }
        [Required(ErrorMessage = "Bu Alan Boş Geçilemez")]
        public string password { get; set; }
        [Required(ErrorMessage = "Bu Alan Boş Geçilemez")]
        [Compare("password",ErrorMessage ="Şifreler Uyuşmuyor")]
        public string confirmPassword { get; set; }
    }
}
