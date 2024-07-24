// Demo145 - Sending Email
// TOSINSO C# Mega Course

using System.Net;
using System.Net.Mail;
using System.Text;

SmtpClient client = new SmtpClient("mailserver.tosinso.com", 25);

client.Credentials = new NetworkCredential("ahmadi@tosinso.com", "123456");

MailAddress from = new MailAddress("ahmadi@tosinso.com", "Hossein Ahmadi");
MailAddress to = new MailAddress("nasiri@tosinso.com","Mohammad Nasiri");

MailMessage message = new MailMessage(from, to);
message.Subject = "TOSINSO.COM Weekly report #12";
message.SubjectEncoding = Encoding.UTF8;

message.Body = "This is a <b>weekly</b> report";
message.IsBodyHtml = true;

client.Send(message);