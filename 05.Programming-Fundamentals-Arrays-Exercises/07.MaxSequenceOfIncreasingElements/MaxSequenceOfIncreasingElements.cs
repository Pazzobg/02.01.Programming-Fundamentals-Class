namespace _07.MaxSequenceOfIncreasingElements
{
    using System;
    using System.Linq;

    public class MaxSequenceOfIncreasingElements
    {
        public static void Main()
        {
            int[] numbers = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();

            int counter = 1;
            int bestLength = 1;
            int startIncrease = 0;

            for (int i = 1; i < numbers.Length; i++)    
            {
                if (numbers[i] > numbers[i - 1])
                {
                    counter++;
                }
                else
                {
                    counter = 1;
                }

                if (counter > bestLength)
                {
                    bestLength = counter;
                    startIncrease = i - bestLength + 1;     
                }                                           
            }

            for (int i = startIncrease; i < startIncrease + bestLength; i++)   
            {                                                                  
                Console.Write($"{numbers[i]} ");                               
            }                                                                      

            Console.WriteLine();
        }
    }
}
