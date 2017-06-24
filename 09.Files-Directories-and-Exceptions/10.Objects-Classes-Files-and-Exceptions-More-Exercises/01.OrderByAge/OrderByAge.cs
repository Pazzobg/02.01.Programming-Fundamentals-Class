namespace _01.OrderByAge
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class OrderByAge
    {
        public static void Main()
        {
            var persons = new List<Person>();

            string[] input = Console.ReadLine().Split(' ');

            while (input[0] != "End")
            {
                string name = input[0];
                string id = input[1];
                int age = int.Parse(input[2]);

                var currentPerson = new Person
                {
                    Name = name,
                    Id = id,
                    Age = age
                };

                persons.Add(currentPerson);

                input = Console.ReadLine().Split(' ');
            }

            foreach (var person in persons.OrderBy(x => x.Age))
            {
                string name = person.Name;
                string id = person.Id;
                int age = person.Age;

                Console.WriteLine($"{name} with ID: {id} is {age} years old.");
            }
        }
    }
}
