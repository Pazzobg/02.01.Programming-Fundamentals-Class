namespace _07.MultiplyBigNumber
{
    using System;
    using System.Text;

    public class MultiplyBigNumber
    {
        public static void Main()
        {
            string num1 = Console.ReadLine().TrimStart('0');
            int multiplier = int.Parse(Console.ReadLine());

            if (multiplier == 0)
            {
                Console.WriteLine(0);
                return;
            }

            var result = new StringBuilder();

            int loopEnd = num1.Length;
            int product = 0;
            int memory = 0;


            for (int i = num1.Length - 1; i >= 0; i--)
            {
                int currentNum = (int)char.GetNumericValue(num1[i]);
                product = (currentNum * multiplier) + memory;
                result.Append(product % 10);

                memory = product > 9 ? product / 10 : 0;
            }

            if (memory > 0)
            {
                result.Append(memory);
            }

            var output = result.ToString().ToCharArray();
            Array.Reverse(output);

            Console.WriteLine(string.Join(string.Empty, output));
        }
    }
}
