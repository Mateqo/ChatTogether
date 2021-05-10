using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mail;
using System.Threading.Tasks;

namespace ChatTogether.Web.Email
{
    public class Email
    {
        public static void SendEmail(string EmailAdress,string Nickname,string ActivationLink)
        {
            MailMessage mailMessage = new MailMessage("chat.tog3ther@gmail.com", EmailAdress);
            mailMessage.Body = "Witaj w naszej aplikacji "+Nickname+"\nTylko jeden krok dzieli Cię od korzystania z ChatTogether." +
                " Kliknij w link aby aktywować swoje konto.\n"+ActivationLink;
            mailMessage.Subject = "Witamy w ChatTogether";

            SmtpClient smtpClient = new SmtpClient("smtp.gmail.com", 587);
            smtpClient.Credentials = new System.Net.NetworkCredential()
            {
                UserName = "chat.tog3ther@gmail.com",
                Password = "Pro123jekt"
            };
            smtpClient.EnableSsl = true;
            smtpClient.Send(mailMessage);
        }
    }
}
