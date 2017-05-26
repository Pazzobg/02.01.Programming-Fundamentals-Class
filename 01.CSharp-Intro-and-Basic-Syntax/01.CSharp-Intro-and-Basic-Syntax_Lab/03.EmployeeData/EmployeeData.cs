namespace _03.EmployeeData
{
    using System; 

    public class EmployeeData
    {
        public static void Main()
        {
            string name = Console.ReadLine();
            int age = int.Parse(Console.ReadLine());
            int employeeId = int.Parse(Console.ReadLine());
            double salary = double.Parse(Console.ReadLine());

            Console.WriteLine($"Name: {name}\nAge: {age}\nEmployee ID: {employeeId:d8}\nSalary: {salary:f2}");
        }
    }
}
