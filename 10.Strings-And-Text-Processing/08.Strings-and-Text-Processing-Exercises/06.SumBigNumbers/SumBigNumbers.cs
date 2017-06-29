namespace _06.SumBigNumbers
{
    using System;
    using System.Text;

    public class SumBigNumbers
    {
        public static void Main()
        {
            string num1 = Console.ReadLine();
            string num2 = Console.ReadLine();

            var result = new StringBuilder();

            if (num1.Length > num2.Length)
            {
                num2 = num2.PadLeft(num1.Length, '0');
            }
            else if (num2.Length > num1.Length)
            {
                num1 = num1.PadLeft(num2.Length, '0');
            }

            int loopEnd = num1.Length;
            int sum = 0;
            int memory = 0;

            for (int i = loopEnd - 1; i >= 0; i--)
            {
                sum = (int)char.GetNumericValue(num1[i]) + (int)char.GetNumericValue(num2[i]) + memory;

                result.Append(sum % 10);

                memory = sum > 9 ? 1 : 0;
            }

            if (memory == 1)
            {
                result.Append(1);
            }

            var output = result.ToString().ToCharArray();
            Array.Reverse(output);

            string print = string.Join(string.Empty, output);

            Console.WriteLine(print.TrimStart('0'));
        }
    }
}
