namespace _04.TrippleSum
{
    using System;

    public class TrippleSum
    {
        public static void Main()
        {
            string[] line = Console.ReadLine().Split(' ');
            ulong[] numbers = new ulong[line.Length];

            for (int i = 0; i < numbers.Length; i++)
            {
                numbers[i] = ulong.Parse(line[i]);
            }

            ulong sum = 0;
            bool found = false;

            for (int i = 0; i < numbers.Length; i++)
            {
                for (int j = 0; j < numbers.Length; j++)
                {
                    sum = numbers[i] + numbers[j];

                    foreach (var number in numbers)
                    {
                        if (sum == number && j > i)
                        {
                            Console.WriteLine($"{numbers[i]} + {numbers[j]} == {number}");
                            found = true;
                            break;
                        }
                    }

                }
            }

            if (!found)
            {
                Console.WriteLine("No");
            }
        }
    }
}
