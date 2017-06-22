namespace _08.AverageGrades
{
    using System;
    using System.Collections.Generic;
    using System.IO;
    using System.Linq;

    public class AverageGrades
    {
        public static void Main()
        {
            var students = new List<Student>();

            string[] inputLines = File.ReadAllLines("input.txt");

            for (int i = 1; i < inputLines.Length; i++)
            {
                string input = inputLines[i];
                string currentName = input.Split(' ')[0];
                double[] currentGrades = input.Split(' ').Skip(1).Select(double.Parse).ToArray();

                var currentStudent = new Student
                {
                    Name = currentName,
                    Grades = currentGrades
                };

                students.Add(currentStudent);
            }

            students = students.Where(x => x.AverageGrade >= 5).ToList();
            string result = string.Empty;

            foreach (var student in students.OrderBy(st => st.Name).ThenByDescending(grade => grade.AverageGrade))
            {
                result += $"{student.Name} -> {student.AverageGrade:f2}{Environment.NewLine}";
            }

            File.WriteAllText("output.txt", result);
        }
    }
}
