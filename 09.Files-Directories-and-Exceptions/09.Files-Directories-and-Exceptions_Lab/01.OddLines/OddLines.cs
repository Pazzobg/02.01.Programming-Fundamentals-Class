namespace _01.OddLines
{
    using System;
    using System.Collections.Generic;
    using System.IO;

    public class OddLines
    {
        public static void Main()
        {
            string[] textAsLinesArr = File.ReadAllLines(@"D:\SoftUni\...\Resources\01. Odd Lines\Input.txt");

            List<string> outputTextLines = new List<string>();

            for (int i = 1; i < textAsLinesArr.Length; i += 2)
            {
                outputTextLines.Add(textAsLinesArr[i]);
            }

            File.WriteAllLines("output.txt", outputTextLines);
        }
    }
}
