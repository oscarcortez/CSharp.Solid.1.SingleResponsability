using System;
using System.Net;
using System.Net.Mail;

namespace ModelsBad
{
    public class InvitationServiceBad
    {
        public string UserNameService { get; set; }

        public string EmailService { get; set; }

        public InvitationServiceBad()
        {        
        }

        public InvitationServiceBad(string userNameService, string emailService)
        {
            UserNameService = userNameService;
            EmailService = emailService;
        }

        public string SendInvite(string email, string firstName, string lastName)
        {
            if (String.IsNullOrWhiteSpace(firstName) || string.IsNullOrWhiteSpace(lastName))
                throw new Exception("Name is not valid");

            if (!email.Contains("@") || !email.Contains("."))
                throw new Exception("Email is not valid");

            return $"UserName: {firstName}{lastName} \n" +
                   $"Email: {email}\n" +
                   $"Body: Este es el mensaje del correo";
        }
    }
}
