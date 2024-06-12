//using Microsoft.AspNetCore.Identity.UI.Services;
//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace Fitness.Utility
//{
//    public class EmailSender : IEmailSender
//    {
//        public Task SendEmailAsync(string email, string subject, string htmlMessage)
//        {
//            // logic 2 send email
//            return Task.CompletedTask;
//        }
//    }
//}


using System;
using MailKit.Net.Smtp;
using MimeKit;
using MimeKit.Text;

namespace Fitness.Utility
{
    public class EmailSender
    {
        public void SendEmailWithPdf(string recipientEmail, string subject, string body, string pdfFilePath)
        {
            var message = new MimeMessage();
            message.From.Add(new MailboxAddress("FitnessApp", "cux@int.pl"));
            message.To.Add(new MailboxAddress("Brawo Ty! To Twój pierwszy krok do zdrowego trybu życia!", recipientEmail));
            message.Subject = subject;

            var bodyBuilder = new BodyBuilder
            {
                TextBody = body
            };

            // Dodanie załącznika PDF
            bodyBuilder.Attachments.Add(pdfFilePath);

            message.Body = bodyBuilder.ToMessageBody();

            using (var client = new SmtpClient())
            {
                client.Connect("smtp.example.com i co dali?", 587, false); // <- xD
                client.Authenticate("fitness@domain.com", "your-password"); // <- xD

                client.Send(message);
                client.Disconnect(true);
            }
        }
    }
}

