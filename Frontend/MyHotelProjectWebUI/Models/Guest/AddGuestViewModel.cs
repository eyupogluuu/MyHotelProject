using System.ComponentModel.DataAnnotations;

namespace MyHotelProjectWebUI.Models.Guest
{
    public class AddGuestViewModel
    {
       
        public string? name { get; set; }
        public string? surname { get; set; }
        public string? city { get; set; }
    }
}
