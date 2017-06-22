namespace _02.LineNumbers
{
    using System;
    using System.Collections.Generic;
    using System.IO;

    public class LineNumbers
    {
        public static void Main()
        {
            string[] textAsLinesArr = File.ReadAllLines(@"D:\SoftUni\...\Resources\02. Line Numbers\input.txt");

            var output = new List<string>();

            for (int i = 0; i < textAsLinesArr.Length; i++)
            {
                string currentLine = $"{i + 1}. {textAsLinesArr[i]}";
                output.Add(currentLine);
            }

            File.WriteAllLines("OutputNumberedLines.txt", output);
        }
    }
}
