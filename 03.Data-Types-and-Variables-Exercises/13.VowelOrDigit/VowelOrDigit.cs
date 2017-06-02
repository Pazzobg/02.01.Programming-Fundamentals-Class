namespace _13.VowelOrDigit
{
    using System;

    public class VowelOrDigit
    {
        public static void Main()
        {
            char input = char.Parse(Console.ReadLine());

            if (input == 'a' || input == 'o' || input == 'u' || input == 'e' || input == 'i')
            {
                Console.WriteLine("vowel");
            }
            else if (char.IsNumber(input))
            {
                Console.WriteLine("digit");
            }
            else
            {
                Console.WriteLine("other");
            }


            //string input = Console.ReadLine();
            //int outNum = 0;

            //bool parsedSuccessfully = int.TryParse(input, out outNum);

            //if (parsedSuccessfully)
            //{
            //    Console.WriteLine("digit");
            //}
            //else
            //{
            //    switch (input)
            //    {
            //        case "a":
            //        case "e":
            //        case "i":
            //        case "o":
            //        case "u": Console.WriteLine("vowel"); break;
            //        default: Console.WriteLine("other"); break;
            //    }
            //}
        }
    }
}
