using MailKit.Security;
using Microsoft.AspNetCore.Mvc;
using MimeKit;
using MailKit.Net.Smtp;
namespace ShoppingMongo.Controllers
{
    public class MailController : Controller
    {
        [HttpPost]
        public IActionResult SendMail(string email)
        {
            var message = new MimeMessage();
            message.From.Add(MailboxAddress.Parse("gonderenmail@gmail.com")); // Gönderen mail
            message.To.Add(MailboxAddress.Parse(email)); // Kullanıcının maili
            message.Subject = "İndirim Kuponunuz!";
            message.Body = new TextPart("plain")
            {
                Text = "Merhaba ilgili kişi, hesabınıza %20’lik indirim kuponu tanımlanmıştır. Kod: 254585"
            };

            var smtp = new SmtpClient();
            smtp.Connect("smtp.gmail.com", 587, SecureSocketOptions.StartTls);
            smtp.Authenticate("yd15808@gmail.com", "dkmk zhis eacb dkzf"); // Uygulama şifresi
            smtp.Send(message);
            smtp.Disconnect(true);

            return Content("Kupon maili gönderildi.");
        }
    }
}

