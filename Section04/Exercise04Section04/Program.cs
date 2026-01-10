using System.Globalization;

namespace Exercise04Section04
{
    internal class Program
    {
        static void Main(string[] args)
        {
            CultureInfo.DefaultThreadCurrentCulture = CultureInfo.InvariantCulture; // A nice discovery

            Employee employee = new Employee();

            Console.Write("Nome: ");
            employee.Name = Console.ReadLine();
            Console.Write("Salário bruto: ");
            employee.GrossSalary = double.Parse(Console.ReadLine() ?? "0");
            Console.Write("Imposto: ");
            employee.Tax = double.Parse(Console.ReadLine() ?? "0");

            Console.WriteLine($"Funcionário: {employee}");

            Console.Write("Digite a porcentagem para aumentar o salário: ");
            employee.IncreaseSalary(double.Parse(Console.ReadLine() ?? "0"));

            Console.WriteLine($"Dados atualizados: {employee}");
        }
    }
}