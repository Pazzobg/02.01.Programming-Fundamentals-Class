namespace _10.CenturiesToNanoseconds
{
    using System;

    public class CenturiesToNanoseconds
    {
        public static void Main()
        {
            byte centuries = byte.Parse(Console.ReadLine());

            ushort years = (ushort)(centuries * 100);
            uint days = (uint)(years * 365.2422);
            uint hours = days * 24;
            ulong minutes = (ulong)(hours * 60);
            ulong seconds = minutes * 60;
            ulong miliseconds = seconds * 1000;
            ulong microseconds = miliseconds * 1000;
            decimal nanoseconds = microseconds * 1000m;

            Console.WriteLine($"{centuries} centuries = {years} years = {days} days = {hours} hours = " +
                $"{minutes} minutes = {seconds} seconds = {miliseconds} milliseconds" +
                $" = {microseconds} microseconds = {nanoseconds} nanoseconds");
        }
    }
}
