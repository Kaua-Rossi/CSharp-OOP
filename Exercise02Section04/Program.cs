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
            employee1.name = Console.ReadLine();
            Console.Write("Salário: ");
            employee1.salary = float.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.WriteLine("Dados do segundo funcionário: ");
            Console.Write("Nome: ");
            employee2.name = Console.ReadLine();
            Console.Write("Salário: ");
            employee2.salary = float.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.WriteLine($"Salário médio: {(employee1.salary + employee2.salary) / 2}");
        }
    }
}