using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;

namespace _2StepAuthentificationChainOfResp.ViewBindings
{
    public class MailSender
    {
        public void SendMail(int n, string address)
        {
            try
            {
                MailMessage mail = new MailMessage();
                SmtpClient smtp = new SmtpClient();

                mail.From = new MailAddress("atltaskproducer@gmail.com");
                mail.To.Add(address);

                mail.Subject = $"Mail From Facepook";
                mail.Body = $"Your verification code is  {n}.";

                smtp.Host = "smtp.gmail.com";
                smtp.Port = 587;
                smtp.Credentials = new System.Net.NetworkCredential("atltaskproducer@gmail.com", "atl12345");
                smtp.EnableSsl = true;
                smtp.Send(mail);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}
