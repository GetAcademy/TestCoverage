using System.Text;

namespace TestCoverage
{
    public class NumberService
    {
        static readonly string[] _names = "null,en,to,tre,fire,fem,feks,sju,åtte,ni".Split(',');

        public static string Describe(int number)
        {
            var sb = new StringBuilder();
            try
            {
                if (number % 2 == 0)
                {
                    sb.AppendLine("Partall");
                }
                else
                {
                    sb.AppendLine("Oddetall");
                }

                if (number < 10)
                {
                    sb.AppendLine("Ett siffer");
                }
                else if (number < 100)
                {
                    sb.AppendLine("To siffer");
                }
                else if (number < 1000)
                {
                    sb.AppendLine("Tre siffer");
                }
                else
                {
                    sb.AppendLine("Mer enn tre siffer");
                }

                var words = number
                        .ToString()
                        .ToCharArray()
                        .Select(c => _names[c - '0']);

                var txt = string.Join(' ', words);
                sb.AppendLine(txt);
            }
            catch (Exception)
            {
                sb.AppendLine("Kan ikke gjøre om tallet til ord");
            }

            return sb.ToString();
        }
    }
}
