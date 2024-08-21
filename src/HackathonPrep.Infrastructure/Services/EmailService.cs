using HackathonPrep.Application.Common.Interfaces;

namespace HackathonPrep.Infrastructure.Services;

public class EmailService : IEmailService
{
    public void SendEmail(string to, string content)
    {
        //var email = new MimeMessage();
        //var mm = _configuration["SendApply:Email"];
        //var ms = _configuration["SendApply:Password"];
        //email.From.Add(MailboxAddress.Parse(mm));
        //email.To.Add(MailboxAddress.Parse(to));
        //email.Subject = "JobStack apply";
        //email.Body = new TextPart(TextFormat.Html) { Text = content };
        //using (SmtpClient smtp = new())
        //{
        //    smtp.Connect("smtp.office365.com", 587, SecureSocketOptions.StartTls);
        //    smtp.Authenticate(mm, ms);
        //    smtp.Send(email);
        //    smtp.Disconnect(true);
        //}
    }
}
