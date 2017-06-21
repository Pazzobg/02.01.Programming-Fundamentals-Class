namespace _08.MentorGroup
{
    using System;
    using System.Collections.Generic;
    using System.Globalization;
    using System.Linq;

    public class MentorGroup
    {
        public static void Main()
        {
            var studentsCommentsDates = new SortedDictionary<string, Student>();

            string[] input = Console.ReadLine().Split(' ', ',');

            while (input[0] != "end")
            {
                var currentStudent = new Student
                {
                    Name = input[0],
                    Attendancy = new List<DateTime>(),
                    Comments = new List<string>()
                };

                if (input.Length > 1)
                {
                    for (int i = 1; i < input.Length; i++)
                    {
                        DateTime dateAttended = DateTime.ParseExact(
                            input[i], "dd/MM/yyyy", CultureInfo.InvariantCulture);

                        currentStudent.Attendancy.Add(dateAttended);
                    }
                }

                if (!studentsCommentsDates.ContainsKey(currentStudent.Name))
                {
                    studentsCommentsDates[currentStudent.Name] = currentStudent;
                }
                else
                {
                    studentsCommentsDates[currentStudent.Name].Attendancy.AddRange(currentStudent.Attendancy);
                }

                input = Console.ReadLine().Split(' ', ',');
            }

            string[] comment = Console.ReadLine().Split('-');

            while (comment[0] != "end of comments")
            {
                string person = comment[0];
                string line = comment[1];

                if (!studentsCommentsDates.ContainsKey(person))
                {
                    comment = Console.ReadLine().Split('-');
                    continue;
                }

                studentsCommentsDates[person].Comments.Add(line);

                comment = Console.ReadLine().Split('-');
            }

            foreach (var studentCollectedInfo in studentsCommentsDates)
            {
                string studentName = studentCollectedInfo.Key;
                var commentsAndAttendancyLists = studentCollectedInfo.Value;

                Console.WriteLine(studentName);
                Console.WriteLine("Comments:");

                foreach (var currentComment in commentsAndAttendancyLists.Comments)
                {
                    Console.WriteLine($"- {currentComment}");
                }

                Console.WriteLine("Dates attended:");

                foreach (var date in commentsAndAttendancyLists.Attendancy.OrderBy(x => x.Date))
                {
                    Console.WriteLine($"-- {date.ToString("dd/MM/yyyy", CultureInfo.InvariantCulture)}");
                }
            }
        }
    }
}
