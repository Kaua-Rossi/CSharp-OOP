using System.Globalization;

namespace Exercise02Section04
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Employee employee1 = new Employee(), employee2 = new Employee();

            Console.WriteLine("Dados do primeiro funcionário: ");
            Console.Write("Nome: ");
            employee1.Name = Console.ReadLine();
            Console.Write("Salário: ");
            employee1.Salary = float.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.WriteLine("Dados do segundo funcionário: ");
            Console.Write("Nome: ");
            employee2.Name = Console.ReadLine();
            Console.Write("Salário: ");
            employee2.Salary = float.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.WriteLine($"Salário médio: {(employee1.Salary + employee2.Salary) / 2}");
        }
    }
}