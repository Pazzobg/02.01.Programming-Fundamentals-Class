namespace _17.BePositive_Debugging
{
    using System;
    using System.Collections.Generic;

    public class BePositive_Debugging
    {
        public static void Main()
        {
            short countSequences = short.Parse(Console.ReadLine());

            for (short i = 0; i < countSequences; i++)
            {
                string[] input = Console.ReadLine().Trim().Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
                var numbers = new List<int>();

                for (short j = 0; j < input.Length; j++)
                {
                    numbers.Add(int.Parse(input[j]));
                }

                bool found = false;

                for (short j = 0; j < numbers.Count; j++)
                {
                    int currentNum = numbers[j];

                    if (currentNum >= 0)
                    {
                        if (found)
                        {
                            Console.Write(" ");
                        }

                        Console.Write(currentNum);

                        found = true;
                    }
                    else if (j < numbers.Count - 1)
                    {
                        currentNum += numbers[j + 1];

                        if (currentNum >= 0)
                        {
                            if (found)
                            {
                                Console.Write(" ");
                            }

                            Console.Write(currentNum);

                            found = true;
                        }

                        j++;
                    }
                }

                if (!found)
                {
                    Console.Write("(empty)");
                }

                Console.WriteLine();
            }
        }
    }
}
