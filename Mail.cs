using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Net.Mail;
using System.Net;
using System.Reflection.Metadata.Ecma335;

namespace Mail
{
	class Program
	{
		static void Main(string[] args)
		{
			//587 for gmail
			var client = new SmtpClient("smtp.gmail.com", 587)
			{
				Credentials = new NetworkCredential("your mail here", "your password here"),
				EnableSsl = true
			};
			
			try
			{
				//the first one is sender the second one is reciever.
				client.Send("sender mail", "reciever mail", "test", "testbody");
			}
			catch (SmtpException ex)
			{
				Console.WriteLine(ex.ToString());
			}

			Console.WriteLine("Sent");
			Console.ReadLine();
		}
	}
}
