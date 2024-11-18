namespace MyHotelProjectWebUI.Models.Contact
{
    public class GetInboxByIDViewModel
    {
        public int contactID { get; set; }
        public string name { get; set; }
        public string mail { get; set; }
        public string subject { get; set; }
        public string ConMessage { get; set; }
        public DateTime Date { get; set; }
    }
}
