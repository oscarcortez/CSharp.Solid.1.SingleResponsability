using System;
using System.Collections.Generic;

namespace ModelsGood
{
    public class InvitationServiceGood
    {
        public string UserNameService { get; set; }

        public string EmailService { get; set; }

        public InvitationServiceGood()
        {
        }

        public InvitationServiceGood(string userNameService, string emailService)
        {
            UserNameService = userNameService;
            EmailService = emailService;
        }

        public string SendInvite(string email, string firstName, string lastName)
        {
            Validate.Email(email);
            Validate.Required(firstName);
            Validate.Required(lastName);

            Dictionary<string, string> result = new();
            result.Add("Email", email);
            result.Add("UserName", $"{firstName}.{lastName}");
            result.Add("Body", "este es el contenido del correo");

            return ConsolePrinter.Print(result).ToString();
        }
    }
}
