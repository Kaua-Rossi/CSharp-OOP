using System.Globalization;

namespace Exercise06Section04
{
    internal class Program
    {
        static void Main(string[] args)
        {
            CultureInfo.DefaultThreadCurrentCulture = CultureInfo.InvariantCulture;

            Console.Write("Qual a cotação do dólar? ");
            double dollarQuotation = double.Parse(Console.ReadLine() ?? "0");
            
            Console.Write("Quantos doláres você vai comprar? ");
            double dollarsToBuy = double.Parse(Console.ReadLine() ?? "0");
            
            Console.WriteLine($"Valor a ser pago em reais = R${CoinConverter.DollarToReal(dollarsToBuy, dollarQuotation):F2}");
        }
    }
}