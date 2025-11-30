using System.Globalization;

namespace Exercise05Section04
{
    internal class Program
    {
        static void Main(string[] args)
        {
            CultureInfo.DefaultThreadCurrentCulture = CultureInfo.InvariantCulture;

            Student student = new Student();

            Console.Write("Nome do aluno: ");
            student.Name = Console.ReadLine();

            Console.WriteLine("Digite as três notas do aluno: ");
            student.FirstQuarterGrade = double.Parse(Console.ReadLine() ?? "0");
            student.SecondQuarterGrade = double.Parse(Console.ReadLine() ?? "0");
            student.ThirdQuarterGrade = double.Parse(Console.ReadLine() ?? "0");

            Console.WriteLine($"NOTA FINAL = {student.FinalGrade():F2}");

            if (student.IsApproved())
            {
                Console.WriteLine("APROVADO");
            }
            else
            {
                Console.WriteLine("REPROVADO");
                Console.WriteLine($"FALTARAM {student.RemainingPoints():F2} PONTOS");
            }
        }
    }
}