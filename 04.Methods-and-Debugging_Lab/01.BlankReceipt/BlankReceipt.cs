namespace _01.BlankReceipt
{
    using System;

    public class BlankReceipt
    {
        public static void Main()
        {
            PrintReceipt();
        }

        public static void PrintReceipt()
        {
            Console.OutputEncoding = System.Text.Encoding.Unicode;
            PrintHeader();
            PrintBody();
            PrintFooter();
        }

        public static void PrintFooter()
        {
            PrintDashes();
            Console.WriteLine("\u00A9 SoftUni");
        }

        public static void PrintBody()
        {
            Console.WriteLine("Charged to____________________");
            Console.WriteLine("Received by___________________");
        }

        public static void PrintHeader()
        {
            Console.WriteLine("CASH RECEIPT");
            PrintDashes();
        }

        public static void PrintDashes()
        {
            Console.WriteLine("------------------------------");
        }
    }
}
