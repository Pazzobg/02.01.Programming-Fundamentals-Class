namespace _05.FolderSize
{
    using System.IO;

    public class FolderSize
    {
        public static void Main()
        {
            string[] files = Directory.GetFiles(@"D:\SoftUni\...\Resources\05. Folder Size\TestFolder");

            double result = 0;

            foreach (var file in files)
            {
                FileInfo currentFile = new FileInfo(file);
                result += currentFile.Length;

            }

            double size = result / 1024 / 1024;
            File.WriteAllText("output.txt", size.ToString());
        }
    }
}
