namespace _04.Elevator
{
    using System;

    public class Elevator
    {
        public static void Main()
        {
            int people = int.Parse(Console.ReadLine());
            int elevatorCapacity = int.Parse(Console.ReadLine());

            if (people % elevatorCapacity == 0)
            {
                Console.WriteLine(people / elevatorCapacity);
            }
            else
            {
                Console.WriteLine((people / elevatorCapacity) + 1);
            }
        }
    }
}