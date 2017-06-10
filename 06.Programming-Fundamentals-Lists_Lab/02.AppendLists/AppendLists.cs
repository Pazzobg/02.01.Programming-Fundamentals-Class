namespace _02.AppendLists
{
    using System;
    using System.Collections.Generic;

    public class AppendLists
    {
        public static void Main()
        {
            string[] line = Console.ReadLine().Split('|');

            var resultList = new List<string>();

            for (int i = line.Length - 1; i >= 0; i--)
            {
                string[] insideValues = line[i].Trim().Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);

                foreach (var num in insideValues)
                {
                    resultList.Add(num);
                }
            }

            Console.WriteLine(string.Join(" ", resultList));
        }
    }
}
