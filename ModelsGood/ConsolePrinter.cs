using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModelsGood
{
    public static class ConsolePrinter
    {        
        public static string Print(Dictionary<string,string> values)
        {            
            StringBuilder result = new();
            foreach(var value in values)
            {
                result.Append(value.Key);
                result.Append(": ");
                result.Append(value.Value);
                result.Append(Environment.NewLine);
            }

            return result.ToString();
        }
    }
}
