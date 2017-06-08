namespace _01.DayOfWeek
{
    using System;

    public class DayOfWeek
    {
        public static void Main()
        {
            string[] daysArr = new string[] {
                "Monday", "Tuesday", "Wednesday", "Thursday", "Friday", "Saturday", "Sunday" };

            int input = int.Parse(Console.ReadLine());
            int index = input - 1;
            string output = string.Empty;

            if (input >= 1 && input <= 7)
            {
                Console.WriteLine(daysArr[index]);
            }
            else Console.WriteLine("Invalid Day!");
        }
    }
}
