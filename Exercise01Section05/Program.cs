namespace Exercise01Section05
{
    internal class Program
    {
        static void Main(string[] args)
        {
            BankAccount account;
            Console.Write("Entre o número da conta: ");
            int accountNumber =  int.Parse(Console.ReadLine() ?? "0");
            Console.Write("Entre o titular da conta: ");
            string holderName =  Console.ReadLine() ?? "";
            Console.Write("Haverá depósito inicial (s/n)? ");
            char input = char.Parse(Console.ReadLine() ?? "");
            if (input != 'S' &&  input != 's')
            {
                account = new BankAccount(accountNumber, holderName);
            }
            else
            {
                Console.Write("Entre o valor de depósito inicial: ");
                double initialDepositValue = double.Parse(Console.ReadLine() ?? "0");
                account = new BankAccount(accountNumber, holderName, initialDepositValue);
            }

            Console.WriteLine("Dados da conta: ");
            Console.WriteLine(account);

            Console.Write("Entre um valor para depósito: ");
            double amount = double.Parse(Console.ReadLine() ?? "0");
            account.Deposit(amount);

            Console.WriteLine("Dados da conta atualizados: ");
            Console.WriteLine(account);
            
            Console.Write("Entre um valor para saque: ");
            amount = double.Parse(Console.ReadLine() ?? "0");
            account.Withdraw(amount);
            
            Console.WriteLine("Dados da conta atualizados: ");
            Console.WriteLine(account);
        }
    }
}