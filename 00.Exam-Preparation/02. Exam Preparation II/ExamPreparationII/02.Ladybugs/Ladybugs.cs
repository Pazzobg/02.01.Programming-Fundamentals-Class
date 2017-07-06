namespace _02.Ladybugs
{
    using System;
    using System.Linq;

    public class Ladybugs
    {
        public static void Main()
        {
            int[] field = new int[int.Parse(Console.ReadLine())];
            int[] ladyBugIndexes = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();

            for (int i = 0; i < field.Length; i++)
            {
                field[i] = ladyBugIndexes.Contains(i) ? 1 : 0;
            }

            string[] input = Console.ReadLine().Split(' ');

            while (input[0] != "end")
            {
                int bugAtPosition = int.Parse(input[0]);
                string direction = input[1].ToLower();
                int jumpsCount = int.Parse(input[2]);

                if (bugAtPosition >= 0 && bugAtPosition <= field.Length - 1)
                {
                    if (field[bugAtPosition] == 0)
                    {
                        input = Console.ReadLine().Split(' ');
                        continue;
                    }

                    field[bugAtPosition] = 0;

                    if (direction == "right")
                    {
                        while (bugAtPosition + jumpsCount < field.Length)
                        {
                            if (field[bugAtPosition + jumpsCount] != 0)
                            {
                                bugAtPosition += jumpsCount;
                            }
                            else
                            {
                                field[bugAtPosition + jumpsCount] = 1;
                                break;
                            }
                        }
                    }
                    else if (direction == "left")
                    {
                        while (bugAtPosition - jumpsCount >= 0)
                        {
                            if (field[bugAtPosition - jumpsCount] != 0)
                            {
                                bugAtPosition -= jumpsCount;
                            }
                            else
                            {
                                field[bugAtPosition - jumpsCount] = 1;
                                break;
                            }
                        }
                    }
                }

                input = Console.ReadLine().Split(' ');
            }

            Console.WriteLine(string.Join(" ", field));
        }
    }
}
