using System.Globalization;

namespace Exercise01Section06
{
    internal class Program
    {
        static void Main(string[] args)
        {
            CultureInfo.DefaultThreadCurrentCulture = CultureInfo.InvariantCulture;

            Student[] rooms = new Student[10];

            Console.Write($"Quantos quartos serão alugados? ");
            byte studentsNumber = byte.Parse(Console.ReadLine() ?? "0");
            
            for (byte i = 0; i < studentsNumber; i++)
            {
                Console.WriteLine($"Aluguel #{i+1}");
                Console.Write("Nome: ");
                string name = Console.ReadLine() ?? "";
                Console.Write("Email: ");
                string email = Console.ReadLine() ?? "";
                Console.Write("Quarto: ");
                byte roomNumber = byte.Parse(Console.ReadLine());
                rooms[roomNumber] = new Student(name, email);
            }

            Console.WriteLine("Quartos ocupados:");
            for (byte i = 0; i < rooms.Length; i++)
            {
                if (rooms[i] != null)
                {
                    Console.WriteLine($"{i}: {rooms[i]}");
                }
            }

        }
    }
}