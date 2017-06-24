namespace _05.WriteToFile
{
    using System;
    using System.IO;

    public class WriteToFile
    {
        public static void Main()
        {
            var text = File.ReadAllText("D:\\SoftUni\\...\\sample_text.txt");

            string[] result = text.Split(".,?!:".ToCharArray(), StringSplitOptions.RemoveEmptyEntries);

            File.WriteAllText("output.txt", string.Join(string.Empty, result));
        }
    }
}
