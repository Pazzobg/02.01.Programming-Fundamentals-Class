using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _00.Practice
{
    class Program
    {
        static void Main(string[] args)
        {
            var array = new long[3] { 1, 2, 3 };
            long firstValue = array[0];
            for (int i = 0; i < array.Length - 1; i++)
            {
                array[i] = array[i + 1];
            }
            array[array.Length - 1] = firstValue;
            Console.WriteLine(string.Join(", ", array));
        }
    }
}
