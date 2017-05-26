//using System;

//public class WordInPlural
//{
//    public static void Main()
//    {
//        string word = Console.ReadLine();

//        if (word.EndsWith("y"))
//        {
//            string newWordRemovedEnding = word.Remove(word.Length - 1);
//            Console.WriteLine($"{newWordRemovedEnding}ies");
//        }
//        else if (word.EndsWith("o") || word.EndsWith("ch") || word.EndsWith("s")
//            || word.EndsWith("sh") || word.EndsWith("x") || word.EndsWith("z"))
//        {
//            Console.WriteLine($"{word}es");
//        }
//        else
//        {
//            Console.WriteLine($"{word}s");
//        }
//    }
//}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05.Word_in_Plural
{
    class Program
    {
        static void Main(string[] args)
        {
            string word = Console.ReadLine();

            bool lastLetterY = word.EndsWith("y");
            bool lastLetterZ = word.EndsWith("z");
            bool lastLetterO = word.EndsWith("o");
            bool lastLetterCH = word.EndsWith("ch");
            bool lastLetterS = word.EndsWith("s");
            bool lastLetterSH = word.EndsWith("sh");
            bool lastLetterX = word.EndsWith("x");

            if (lastLetterY)
            {
                int remove = word.IndexOf("y");
                word = word.Replace("y", "ies");
            }
            else if (lastLetterO)
            {
                int remove = word.IndexOf("o");
                word = word.Replace("o", "oes");
            }
            else if (lastLetterZ)
            {
                int remove = word.IndexOf("z");
                word = word.Replace("z", "zes");
            }
            else if (lastLetterCH)
            {
                int remove = word.IndexOf("ch");
                word = word.Replace("ch", "ches");
            }
            else if (lastLetterS)
            {
                int remove = word.IndexOf("s");
                word = word.Replace("s", "ses");
            }
            else if (lastLetterSH)
            {
                int remove = word.IndexOf("sh");
                word = word.Replace("sh", "shes");
            }
            else if (lastLetterX)
            {
                int remove = word.IndexOf("x");
                word = word.Replace("x", "xes");
            }
            else
            {
                word += "s";
            }

            Console.WriteLine(word);
        }
    }
}