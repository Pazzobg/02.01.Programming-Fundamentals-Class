namespace _15.BallancedBrackets
{
    using System;

    public class BallancedBrackets
    {
        public static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            bool balanced = false;
            bool opened = false;
            bool closed = true;

            for (int i = 0; i < n; i++)
            {
                string input = Console.ReadLine();

                if (input != "(" && input != ")")
                {
                    continue;
                }

                if (input == ")" && !opened)
                {
                    balanced = false;
                    break;
                }
                else if (input == ")" && opened)
                {
                    opened = false;
                    closed = true;
                    balanced = true;
                }


                if (input == "(" && !closed)
                {
                    balanced = false;
                    break;
                }
                else if (input == "(" && closed)
                {
                    opened = true;
                    closed = false;
                    balanced = false;
                }
            }

            if (balanced)
            {
                Console.WriteLine("BALANCED");

            }
            else
            {
                Console.WriteLine("UNBALANCED");
            }
        }
    }
}
