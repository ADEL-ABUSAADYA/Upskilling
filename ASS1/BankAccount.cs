namespace DAY_ONE;

public class BankAccount
{
    public string AccountNumber { get; }
    public string AccountHolderName { get; set; }
    public decimal Balance { get; private set; } 
    
    public BankAccount(string accountNumber, string accountHolderName, decimal initialBalance = 0)
    {
        AccountNumber = accountNumber;
        AccountHolderName = accountHolderName;
        Balance = initialBalance;
    }
    public void Deposit(decimal amount)
    {
        if (amount > 0)
        {
            Balance += amount;
        }
        else
        {
            Console.WriteLine("Deposit amount must be positive.");
        }
    }
    public void Withdraw(decimal amount)
    {
        if (amount > 0 && amount <= Balance)
        {
            Balance -= amount;
        }
        else if (amount > Balance)
        {
            Console.WriteLine("Insufficient balance.");
        }
        else
        {
            Console.WriteLine("Withdrawal amount must be positive.");
        }
    }
}