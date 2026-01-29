using System.Globalization;

namespace Exercise02Section06
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("How many employees will be registered? ");
            int employeesNumber = int.Parse(Console.ReadLine() ?? "0");

            List<Employee> employees = new List<Employee>();

            for (int i = 0; i < employeesNumber; i++)
            {
                Console.WriteLine($"Employee #{i + 1}:");
                Console.Write("Id: ");
                int id = int.Parse(Console.ReadLine() ?? "0");
                Console.Write("Name: ");
                string name = Console.ReadLine() ?? string.Empty;
                Console.Write("Salary: ");
                double salary = double.Parse(Console.ReadLine() ?? "0", CultureInfo.InvariantCulture);

                employees.Add(new Employee(id, name, salary));
            }

            Console.Write("Enter the employee id that will have salary increase: ");
            int searchId = int.Parse(Console.ReadLine() ?? "-1");
            
            Employee? employeeToIncreaseSalary = employees.Find(e => e.Id == searchId);

            if (employeeToIncreaseSalary != null)
            {
                Console.Write("Enter the percentage: ");
                double percentage = double.Parse(Console.ReadLine() ?? "0", CultureInfo.InvariantCulture);

                employeeToIncreaseSalary.IncreaseSalary(percentage);
            }
            else
            {
                Console.WriteLine("This id does not exist!");
            }

            Console.WriteLine("Updated list of employees:");

            foreach (Employee emp in employees)
            {
                Console.WriteLine(emp);
            }
        }
    }
}