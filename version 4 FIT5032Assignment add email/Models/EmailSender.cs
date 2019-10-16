using SendGrid;
using SendGrid.Helpers.Mail;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace FIT5032Assignment.Models
{
    public class EmailSender
    {
        // Please use your API KEY here.
        private const String API_KEY = "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";

        public void Send(String toEmail, String subject, String contents)
        {
            var client = new SendGridClient(API_KEY);
            var from = new EmailAddress("E-Karaoke@localhost.com", "FIT5032 Di Chen 29501822");
            var to = new EmailAddress(toEmail, "");
            var plainTextContent = contents;
            var htmlContent = "<p>" + contents + "</p>";
            var msg = MailHelper.CreateSingleEmail(from, to, subject, plainTextContent, htmlContent);
            var response = client.SendEmailAsync(msg);
        }
    }
}