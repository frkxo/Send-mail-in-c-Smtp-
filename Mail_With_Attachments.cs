using System;
using System.Net;
using System.Net.Mail;

namespace Mail
{
	class Program
	{
		static void Main(string[] args)
		{
			MailMessage mail = new MailMessage();
			SmtpClient SmtpServer = new SmtpClient("smtp.gmail.com");
			mail.From = new MailAddress("Source Gmail Address");
			mail.To.Add("Reciever Gmail Address");
			mail.Subject = "Your mail's subject";
			mail.Body = "Your mail's body";
			System.Net.Mail.Attachment attachment;
			attachment = new System.Net.Mail.Attachment("Your Attachment(Optional)");
			mail.Attachments.Add(attachment);

			SmtpServer.Port = 587; //This is for Gmail
			SmtpServer.Credentials = new System.Net.NetworkCredential("Source Gmail Address", "Source Gmail password");
			SmtpServer.EnableSsl = true;

			SmtpServer.Send(mail);

			Console.WriteLine("From :" + mail.From.ToString());
			Console.WriteLine("To :" + mail.To.ToString());
			Console.WriteLine("Subject :" + mail.Subject);
			Console.WriteLine("Date :" + DateTime.Now.ToString("dddd, dd MMMM yyyy HH:mm:ss"));
			Console.WriteLine("Attachment: " + mail.Attachments.Count);
			Console.WriteLine("------------------- BODY -----------------");
			Console.WriteLine(mail.Body);
			Console.Write("------------------- END -----------------\n");

			Console.WriteLine("\nYour mail has been sent.");
			Console.ReadLine();
		}
	}
}
