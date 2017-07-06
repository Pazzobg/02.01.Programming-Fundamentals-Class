namespace _04.Files
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class Files
    {
        public static void Main()
        {
            var filesCollection = new List<File>();
            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                string line = Console.ReadLine();

                string[] input = line.Split('\\');
                string fileRoot = input[0];
                string[] nameSize = input[input.Length - 1].Split(';');
                string fileName = nameSize[0];
                long fileSize = long.Parse(nameSize[1]);
                string fileExtension = string.Empty;
                string[] nameSplitted = fileName.Split('.');
                if (nameSplitted.Length > 1)
                {
                    fileExtension = nameSplitted[nameSplitted.Length - 1];
                }

                bool alreadyPresent = false;
                for (int j = 0; j < filesCollection.Count; j++)
                {
                    var currentFileOnList = filesCollection[j];

                    if (currentFileOnList.Name == fileName && currentFileOnList.Root == fileRoot)
                    {
                        alreadyPresent = true;
                        currentFileOnList.Size = fileSize;
                        break;
                    }
                }

                if (!alreadyPresent)
                {
                    filesCollection.Add(new File
                    {
                        Name = fileName,
                        Extension = fileExtension,
                        Size = fileSize,
                        Root = fileRoot
                    });
                }
            }

            string[] searchQuery = Console.ReadLine().Split(" in".ToCharArray(), StringSplitOptions.RemoveEmptyEntries);
            string searchExtension = searchQuery[0];
            string searchRoot = searchQuery[1];

            var resultList = filesCollection.Where(x => x.Root == searchRoot).ToList();

            bool found = false;

            foreach (var file in resultList
                .Where(f => f.Extension == searchExtension)
                .OrderByDescending(x => x.Size)
                .ThenBy(x => x.Name))
            {
                found = true;
                Console.WriteLine($"{file.Name} - {file.Size} KB");
            }

            if (!found)
            {
                Console.WriteLine("No");
            }
        }
    }
}
