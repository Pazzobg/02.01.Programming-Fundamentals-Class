namespace _01.SortTimes
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Globalization;

    public class SortTimes
    {
        public static void Main()
        {
            var times = new List<string>();
            string[] timeStrings = Console.ReadLine().Split(' ');

            for (int i = 0; i < timeStrings.Length; i++)
            {
                string currentTime = timeStrings[i];
                DateTime timeParsed = DateTime.ParseExact(currentTime, "HH:mm", CultureInfo.InvariantCulture);
                times.Add(timeParsed.ToString("HH:mm"));
                // times.Add(timeParsed.ToShortTimeString()); ==> works on my VS, but not in Judge. 
            }            

            Console.WriteLine(string.Join(", ", times.OrderBy(x => x)));
        }
    }
}
