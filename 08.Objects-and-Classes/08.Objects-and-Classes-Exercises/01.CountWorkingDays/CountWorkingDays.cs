namespace _01.CountWorkingDays
{
    using System;
    using System.Globalization;

    public class CountWorkingDays
    {
        public static void Main()
        {
            DateTime startDate = DateTime.ParseExact(Console.ReadLine(), "dd-MM-yyyy", CultureInfo.InvariantCulture);
            DateTime endDate = DateTime.ParseExact(Console.ReadLine(), "dd-MM-yyyy", CultureInfo.InvariantCulture);

            DateTime[] officialHolidays = AddOfficialHolidays();

            int workingDaysCounter = 0;

            for (DateTime currentDate = startDate; currentDate <= endDate; currentDate = currentDate.AddDays(1))
            {
                if (currentDate.DayOfWeek == DayOfWeek.Saturday || currentDate.DayOfWeek == DayOfWeek.Sunday)
                {
                    continue;
                }

                bool isHoliday = false;

                for (int i = 0; i < officialHolidays.Length; i++)
                {
                    DateTime tempHolidayCheck = officialHolidays[i];

                    if (currentDate.Day == tempHolidayCheck.Day && currentDate.Month == tempHolidayCheck.Month)
                    {
                        isHoliday = true;
                        break;
                    }
                }

                if (!isHoliday)
                {
                    workingDaysCounter++;
                }
            }

            Console.WriteLine(workingDaysCounter);
        }

        public static DateTime[] AddOfficialHolidays()
        {
            DateTime[] officialHolidaysArray = new DateTime[]
            {
                new DateTime (2015, 1, 1),
                new DateTime (2015, 3, 3),
                new DateTime (2015, 5, 1),
                new DateTime (2015, 5, 6),
                new DateTime (2015, 5, 24),
                new DateTime (2015, 9, 6),
                new DateTime (2015, 9, 22),
                new DateTime (2015, 11, 1),
                new DateTime (2015, 12, 24),
                new DateTime (2015, 12, 25),
                new DateTime (2015, 12, 26)
            };

            return officialHolidaysArray;
        }
    }
}
