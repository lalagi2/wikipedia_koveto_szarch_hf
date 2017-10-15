using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net.Mail;
using System.Net;

namespace wikipedia_koveto
{
    class EmailSender
    {
        public void sendEmail(string toAddress, string toName, string subject, string body)
        {
            var fromAddress = new MailAddress("wikipediakoveto@gmail.com", "Wikipedia-koveto alert");
            var toAddresss = new MailAddress(toAddress, toName);
            const string fromPassword = "ventillator";

            var smtp = new SmtpClient
            {
                Host = "smtp.gmail.com",
                Port = 587,
                EnableSsl = true,
                DeliveryMethod = SmtpDeliveryMethod.Network,
                Credentials = new NetworkCredential(fromAddress.Address, fromPassword),
                Timeout = 20000
            };
            using (var message = new MailMessage(fromAddress, toAddresss)
            {
                Subject = subject,
                Body = body
            })
            {
                smtp.Send(message);
            }
        }
    }
}
