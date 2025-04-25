using System;
using System.Net;
using System.Net.Mail;
namespace Zadanie_06;

class Program
{
    static void Main(string[] args)
    {
        string sender = "sender@gmail.com";
        string receiver = "receiver@gmail.com";
        string topic = "topic";
        string message = "message";
        
        
        
        MailMessage mail = new MailMessage(sender, receiver, topic, message);


        string homePath = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
        string CVpath = Path.Combine(homePath, "CV.pdf");
        Attachment attachment = new Attachment(CVpath);
        
        mail.Attachments.Add(attachment);
        
        SmtpClient smtp = new SmtpClient("smtp.gmail.com", 587);
        smtp.EnableSsl = true;
        
        smtp.Credentials = new NetworkCredential("mymail@email.com", "password");


        try
        {
            smtp.Send(mail);
        }
        catch (Exception ex)
        {
            Console.WriteLine(ex.Message);
        }




    }
}