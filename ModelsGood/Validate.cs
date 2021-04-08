using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModelsGood
{
    public static class Validate
    {
        public static void Email(string email)
        {
            if (!email.Contains("@") || !email.Contains("."))
                throw new Exception("Email is not Valid!");
        }

        public static void Required(string value)
        {
            if (String.IsNullOrWhiteSpace(value))
                throw new Exception("The value is not valid");
        }
    }
}
