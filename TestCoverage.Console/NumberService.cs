using System;
using System.Linq;
using System.Text;

namespace TestCoverage.Console
{
    public class NumberService
    {
        private static string[] _names = "null,en,to,tre,fire,fem,feks,sju,åtte,ni".Split(',');
        
        public static string Process(int number)
        {
            var sb = new StringBuilder(); // ok
            try
            {
                if (number % 2 == 0) // ok
                {
                    sb.AppendLine("Partall"); // ok
                }
                else
                {
                    sb.AppendLine("Oddetall"); // ok
                }
                if (number < 10) // ok
                {
                    sb.AppendLine("Ett siffer"); // ok
                }
                else if (number < 100) // ok
                {
                    sb.AppendLine("To siffer"); // ok
                }
                else if (number < 1000) // ok
                {
                    sb.AppendLine("Tre siffer"); // ok
                }

                var words = number //ok
                    .ToString()
                    .ToCharArray()
                    .Select(c => _names[c - '0']);

                var txt = string.Join(' ', words); //ok
                sb.AppendLine(txt);
            }
            catch (Exception)
            {
                sb.AppendLine("Kan ikke gjøre om tall til ord");// ok
            }

            return sb.ToString(); // ok
        }
    }
}
