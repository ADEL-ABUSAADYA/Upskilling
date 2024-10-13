namespace DAY_ONE;

class Program
{
    static void Main(string[] args)
    {
        BankAccount bankAccount = new BankAccount("1000023124", "Adel Abusaadya");

        bankAccount.Deposit(500);
        // bankAccount.Withdraw(500);
        Console.WriteLine(bankAccount.ToString());

        string a = bankAccount.AccountNumber;
    }
}