using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;

namespace testEntityFarmwork {
    public class Mail {
        public void sendMail(string inEmail) {


            MailMessage message = new MailMessage();
            SmtpClient smtp = new SmtpClient();

            message.From = new MailAddress("smartosc.net@gmail.com");
            message.To.Add(new MailAddress(inEmail.ToString()));
            message.Subject = "Hello World";
            message.Body = "Hi " + inEmail + "\nWellcome to SmartOSC ! \nGood bye me love...";
            smtp.Port = 587;
            smtp.Host = "smtp.gmail.com";
            smtp.EnableSsl = true;
            smtp.UseDefaultCredentials = true;
            smtp.Credentials = new NetworkCredential("smartosc.net@gmail.com", "123456789asdasd");
            smtp.DeliveryMethod = SmtpDeliveryMethod.Network;
            smtp.Send(message);
        }
    }
}
