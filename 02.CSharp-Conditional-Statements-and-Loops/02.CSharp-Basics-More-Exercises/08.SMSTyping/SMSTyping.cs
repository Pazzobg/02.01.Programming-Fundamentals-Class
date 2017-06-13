using System;

public class SMSTyping
{
    public static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        string result = string.Empty;

        for (int i = 0; i < n; i++)
        {
            int input = int.Parse(Console.ReadLine());
            string button = input.ToString();
            int timesPressed = button.Length;

            switch (button[0])
            {
                case '2':
                    switch (timesPressed)
                    {
                        case 1: result += 'a'; break;
                        case 2: result += 'b'; break;
                        case 3: result += 'c'; break;
                    }
                    break;
                case '3':
                    {
                        switch (timesPressed)
                        {
                            case 1: result += 'd'; break;
                            case 2: result += 'e'; break;
                            case 3: result += 'f'; break;
                        }
                    }
                    break;
                case '4':
                    {
                        switch (timesPressed)
                        {
                            case 1: result += 'g'; break;
                            case 2: result += 'h'; break;
                            case 3: result += 'i'; break;
                        }
                    }
                    break;
                case '5':
                    {
                        switch (timesPressed)
                        {
                            case 1: result += 'j'; break;
                            case 2: result += 'k'; break;
                            case 3: result += 'l'; break;
                        }
                    }
                    break;
                case '6':
                    {
                        switch (timesPressed)
                        {
                            case 1: result += 'm'; break;
                            case 2: result += 'n'; break;
                            case 3: result += 'o'; break;
                        }
                    }
                    break;
                case '7':
                    {
                        switch (timesPressed)
                        {
                            case 1: result += 'p'; break;
                            case 2: result += 'q'; break;
                            case 3: result += 'r'; break;
                            case 4: result += 's'; break;
                        }
                    }
                    break;
                case '8':
                    {
                        switch (timesPressed)
                        {
                            case 1: result += 't'; break;
                            case 2: result += 'u'; break;
                            case 3: result += 'v'; break;
                        }
                    }
                    break;
                case '9':
                    {
                        switch (timesPressed)
                        {
                            case 1: result += 'w'; break;
                            case 2: result += 'x'; break;
                            case 3: result += 'y'; break;
                            case 4: result += 'z'; break;
                        }
                    }
                    break;
                default: result += ' '; break;
            }
        }

        Console.WriteLine(result);
    }
}