using ModelsBad;
using System;

namespace Solid.SingleResponsabilityExample
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Example of bad model without single responsability principle");

            InvitationServiceBad invitation = new();

            var email = "oscarkortez@gmail.com";
            var firstName = "oscar";
            var lastName = "cortez";
            Console.WriteLine(invitation.SendInvite(email, firstName, lastName));

        }
    }
}
