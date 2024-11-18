using Microsoft.AspNetCore.Mvc;
using MimeKit;
using MyHotelProjectWebUI.Models.Mail;
using MailKit.Net.Smtp;

namespace MyHotelProjectWebUI.Controllers
{
    public class AdminMailController : Controller
    {
        [HttpGet]
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Index(AdminMailViewModel model)
        {
            MimeMessage mimeMessage = new MimeMessage();

            MailboxAddress mailboxAddressFrom = new MailboxAddress("HotelierAdmin", "onureyupoglu95@gmail.com");
            mimeMessage.From.Add(mailboxAddressFrom);

            MailboxAddress mailboxAddressTo = new MailboxAddress("User", model.receiverMail);
            mimeMessage.To.Add(mailboxAddressTo);

            var bodyBuilder = new BodyBuilder();
            bodyBuilder.TextBody = model.body;
            mimeMessage.Body = bodyBuilder.ToMessageBody();

            mimeMessage.Subject = model.subject;

            SmtpClient client = new SmtpClient();
            client.Connect("smtp.gmail.com", 587, false);
            client.Authenticate("feyzanurbakirr@gmail.com", "avrtpfdkebhumiar");
            client.Send(mimeMessage);
            client.Disconnect(true);

            return View();
        }
    }
}
