using System;

public class DNASequences
{
    public static void Main()
    {
        int matchSum = int.Parse(Console.ReadLine());

        int valueI = 0;
        int valueJ = 0;
        int valueK = 0;

        int sum = 0;
        string frame = string.Empty;

        // ASCII        Pts. 
        // 65       A   1
        // 67       C   2
        // 71       G   3
        // 84       T   4

        for (char i = 'A'; i <= 'T'; i++)
        {
            if (i == 65 || i == 67 || i == 71 || i == 84)
            {
                switch ((int)i)
                {
                    case 65: valueI = 1; break;
                    case 67: valueI = 2; break;
                    case 71: valueI = 3; break;
                    case 84: valueI = 4; break;
                }

                for (char j = 'A'; j <= 'T'; j++)
                {
                    if (j == 65 || j == 67 || j == 71 || j == 84)
                    {
                        switch ((int)j)
                        {
                            case 65: valueJ = 1; break;
                            case 67: valueJ = 2; break;
                            case 71: valueJ = 3; break;
                            case 84: valueJ = 4; break;
                        }

                        for (char k = 'A'; k <= 'T'; k++)
                        {
                            if (k == 65 || k == 67 || k == 71 || k == 84)
                            {
                                switch ((int)k)
                                {
                                    case 65: valueK = 1; break;
                                    case 67: valueK = 2; break;
                                    case 71: valueK = 3; break;
                                    case 84: valueK = 4; break;
                                }

                                sum = valueI + valueJ + valueK;

                                if (sum >= matchSum) frame = "O";
                                else frame = "X";

                                Console.Write($"{frame}{i}{j}{k}{frame} ");
                            }
                            else
                            {
                                continue;
                            }
                        }

                        Console.WriteLine();
                    }
                    else
                    {
                        continue;
                    }
                }
            }
            else
            {
                continue;
            }
        }
    }
}