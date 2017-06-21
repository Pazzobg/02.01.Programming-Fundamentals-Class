namespace _10.StudentGroups
{
    using System.Collections.Generic;

    public class Town
    {
        public string Name { get; set; }

        public int Capacity { get; set; }

        public List<Student> RegisteredStudents { get; set; }
    }
}
