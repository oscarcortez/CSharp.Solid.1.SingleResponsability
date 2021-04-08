using ModelsBad;
using ModelsGood;
using System;

namespace Solid.SingleResponsabilityExample
{
    class Program
    {
        static void Main(string[] args)
        {
            var email = "oscarkortez@gmail.com";
            var firstName = "oscar";
            var lastName = "cortez";

            Console.WriteLine("Example of bad model without single responsability principle");
            InvitationServiceBad invitationBad = new();
            Console.WriteLine(invitationBad.SendInvite(email, firstName, lastName));
            
            Console.WriteLine();
            
            Console.WriteLine("Example of bad model without single responsability principle");
            InvitationServiceGood invitationGood = new();
            Console.WriteLine(invitationGood.SendInvite(email, firstName, lastName));

        }
    }
}
