namespace _08.PersonalException
{
    using System;

    public class PersonalException
    {
        public static void Main()
        {
            while (true)
            {
                try
                {
                    int number = int.Parse(Console.ReadLine());

                    if (number < 0)
                    {
                        throw new NegativeValueInputException();
                    }

                    Console.WriteLine(number);
                }
                catch (NegativeValueInputException negativeInputEx)
                {
                    Console.WriteLine(negativeInputEx.Message);
                    break;
                }
            }
        }
    }
}
