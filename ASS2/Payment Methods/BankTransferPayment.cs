namespace ASS2.Payment_Methods;

public class BankTransferPayment : IPaymentStrategy
{
    public string BankAccount { get; set; }
    public string BankName { get; set; }
    
    public BankTransferPayment(string bankAccount, string bankName)
    {
        BankAccount = bankAccount;
        BankName = bankName;
    }
    
    public void ProcessPayment(decimal amount)
    {
        Console.WriteLine($"Processing bank transfer payment of {amount:C} to bank {BankName}.");
        // Logic to process bank transfer
    }
}