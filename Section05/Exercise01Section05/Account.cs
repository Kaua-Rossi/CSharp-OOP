namespace Exercise01Section05;

public class BankAccount
{
    public int AccountNumber { get; private set; }
    private string _holderName = "";
    public string HolderName
    {
        get => _holderName;
        set
        {
            if (value != null && value.Length >= 3)
            {
                _holderName = value;
            }
        }
    }
    public double Balance { get; private set; }

    public BankAccount(int accountNumber, string holderName)
    {
        AccountNumber = accountNumber;
        HolderName = holderName;
        Balance = 0;
    }

    public BankAccount(int accountNumber, string holderName, double initialDepositValue) : this(accountNumber, holderName)
    {
        Deposit(initialDepositValue);
    }
    
    public void Deposit(double amount)
    {
        if (amount > 0)
        {
            Balance += amount;
        }
    }

    public void Withdraw(double amount)
    {
        const byte tax = 5;
        if (amount > 5)
        {
            Balance -= amount + tax;
        }
    }

    public override string ToString()
    {
        return $"Conta: {AccountNumber}, Titular: {HolderName}, Saldo: R${Balance:f2}\n";
    }
}