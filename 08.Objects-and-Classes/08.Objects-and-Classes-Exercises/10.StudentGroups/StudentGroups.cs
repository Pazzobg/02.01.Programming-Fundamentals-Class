namespace _10.StudentGroups
{
    using System;
    using System.Collections.Generic;
    using System.Globalization;
    using System.Linq;

    public class StudentGroups
    {
        public static void Main()
        {
            List<Town> towns = ReadTownsAndStudents();

            List<Group> groups = DistributeStudentsIntoGroups(towns);

            int townsCount = groups
                .Select(x => x.Town)
                .Distinct()
                .Count();

            Console.WriteLine($"Created {groups.Count} groups in {townsCount} towns: ");

            foreach (var group in groups.OrderBy(x => x.Town.Name))
            {
                Console.WriteLine($"{group.Town.Name} => {string.Join(", ", group.Students.Select(x => x.Email))}");
            }
        }

        public static List<Town> ReadTownsAndStudents()
        {
            var towns = new List<Town>();

            string inputLine = Console.ReadLine();

            while (inputLine != "End")
            {
                if (inputLine.Contains("=>"))
                {
                    string[] townNameCapacityInfo = inputLine
                        .Split("=>".ToCharArray(), StringSplitOptions.RemoveEmptyEntries);
                    string townName = townNameCapacityInfo[0].Trim();
                    string[] seatsTokens = townNameCapacityInfo[1].Trim().Split(' ');
                    int seats = int.Parse(seatsTokens[0]);

                    var currentTown = new Town
                    {
                        Name = townName,
                        Capacity = seats,
                        RegisteredStudents = new List<Student>()
                    };

                    towns.Add(currentTown);
                }
                else
                {
                    int lastAddedTown = towns.Count - 1;

                    string[] studentInfo = inputLine.Split('|');
                    string studentName = studentInfo[0].Trim();
                    string studentEmail = studentInfo[1].Trim();
                    DateTime regDate = DateTime.ParseExact(studentInfo[2].Trim(), "d-MMM-yyyy", CultureInfo.InvariantCulture);

                    var currentStudent = new Student
                    {
                        Name = studentName,
                        Email = studentEmail,
                        RegistrationDate = regDate
                    };

                    towns[lastAddedTown].RegisteredStudents.Add(currentStudent);
                }

                inputLine = Console.ReadLine();
            }

            return towns;
        }

        public static List<Group> DistributeStudentsIntoGroups(List<Town> towns)
        {
            var groups = new List<Group>();

            towns = towns.OrderBy(x => x.Name).ToList();

            for (int i = 0; i < towns.Count; i++)
            {
                var currentTown = towns[i];

                currentTown.RegisteredStudents = currentTown.RegisteredStudents
                    .OrderBy(x => x.RegistrationDate)
                    .ThenBy(x => x.Name)
                    .ThenBy(x => x.Email)
                    .ToList();

                while (currentTown.RegisteredStudents.Any())
                {
                    var group = new Group();
                    group.Town = currentTown;
                    group.Students = currentTown.RegisteredStudents
                        .Take(group.Town.Capacity)
                        .ToList();
                    currentTown.RegisteredStudents = currentTown.RegisteredStudents
                        .Skip(group.Town.Capacity)
                        .ToList();

                    groups.Add(group);
                }
            }

            return groups;
        }
    }
}