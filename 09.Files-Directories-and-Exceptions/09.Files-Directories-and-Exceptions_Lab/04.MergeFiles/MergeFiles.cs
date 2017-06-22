namespace _04.MergeFiles
{
    using System;
    using System.Collections.Generic;
    using System.IO;

    public class MergeFiles
    {
        public static void Main()
        {
            string[] inputOne = File.ReadAllLines(@"D:\SoftUni\...\Resources\04. Merge Files\FileOne.txt");
            string[] inputTwo = File.ReadAllLines(@"D:\SoftUni\...\Resources\04. Merge Files\FileTwo.txt");

            var outputStrings = new List<string>();

            for (int i = 0; i < inputOne.Length; i++)
            {
                outputStrings.Add(inputOne[i]);
                outputStrings.Add(inputTwo[i]);
            }

            File.WriteAllLines("output.txt", outputStrings);
        }
    }
}
