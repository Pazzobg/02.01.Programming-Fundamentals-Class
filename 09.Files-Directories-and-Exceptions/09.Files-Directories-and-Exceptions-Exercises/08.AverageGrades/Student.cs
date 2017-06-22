namespace _08.AverageGrades
{
    using System.Collections.Generic;
    using System.Linq;

    public class Student
    {
        public string Name { get; set; }

        public double[] Grades { get; set; }

        public double AverageGrade => Grades.Average();
    }
}
