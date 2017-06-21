namespace _04.AverageGrades
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class AverageGrades
    {
        public static void Main()
        {
            int numberOfStudents = int.Parse(Console.ReadLine());

            var studentsList = new List<Student>();

            for (int i = 0; i < numberOfStudents; i++)
            {
                List<string> input = Console.ReadLine().Split(' ').ToList();

                List<double> gradesCurrentStudent = new List<double>();

                for (int j = 0; j < input.Count - 1; j++)
                {
                    gradesCurrentStudent.Add(double.Parse(input[j + 1]));
                }

                Student currentStudent = new Student
                {
                    Name = input[0],
                    Grades = gradesCurrentStudent
                };

                studentsList.Add(currentStudent);
            }

            foreach (var student in studentsList
                .Where(st => st.AverageGrade >= 5.00)
                .OrderBy(st => st.Name)
                .ThenByDescending(st => st.AverageGrade))
            {
                Console.WriteLine($"{student.Name} -> {student.AverageGrade:f2}");
            }
        }
    }
}
