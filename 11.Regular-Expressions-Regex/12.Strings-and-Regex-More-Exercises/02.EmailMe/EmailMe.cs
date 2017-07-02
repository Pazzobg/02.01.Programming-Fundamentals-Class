namespace _02.EmailMe
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Text.RegularExpressions;
    using System.Threading.Tasks;

    public class EmailMe
    {
        public static void Main()
        {
            string email = Console.ReadLine();

            var regex = new Regex(@"(.*)@(.*)");

            var match = regex.Match(email);

            string charsBefore = match.Groups[1].Value.ToString();
            string charsAfter = match.Groups[2].Value.ToString();

            int sumBefore = 0;
            int sumAfter = 0;

            foreach (var character in charsBefore)
            {
                sumBefore += character;
            }

            foreach (var character in charsAfter)
            {
                sumAfter += character;
            }

            Console.WriteLine(sumBefore>=sumAfter ? "Call her!" : "She is not the one.");
        }
    }
}
