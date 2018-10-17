using System;
using System.Net;
using System.Net.Mail;
using System.Threading.Tasks;
using Microsoft.Extensions.Configuration;
using TchokopassEnterprises4.ViewModels;

namespace TchokopassEnterprises4.Services
{
    public class EmailService : IEmailService

    {
        private readonly IConfiguration _configuration;
        public EmailService(IConfiguration configuration)
        {
            _configuration = configuration;
        }
        public async Task SendEmail(EmailModel objModelMail)
        {
            using (var client = new SmtpClient())
            {
                var credential = new NetworkCredential
                {
                    UserName = _configuration["Email:Email"],
                    Password = _configuration["Email:Password"]
                };

                client.Credentials = credential;
                client.Host = _configuration["Email:Host"];
                client.Port = int.Parse(_configuration["Email:Port"]);
                client.EnableSsl = true;

                using (var emailMessage = new MailMessage())
                {
                    emailMessage.To.Add(new MailAddress("tchokopas.enterprises12@gmail.com"));
                    emailMessage.From = new MailAddress(_configuration["Email:Email"]);
                    emailMessage.ReplyToList.Add(new MailAddress(objModelMail.Email));
                    emailMessage.Subject = objModelMail.Subject;
                    emailMessage.Body = objModelMail.Message;
                    emailMessage.IsBodyHtml = false;
                    client.Send(emailMessage);
                    //await client.SendMailAsync(emailMessage);
                }
            }
            await Task.CompletedTask;
        }        
    }

}
   