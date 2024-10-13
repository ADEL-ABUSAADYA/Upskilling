namespace ASS2.Payment_Methods;

public class CreditCardPayment : IPaymentStrategy
{
    public string CardNumber { get; set; }
    public string CardHolderName { get; set; }
    public string ExpiryDate { get; set; }
    
    public CreditCardPayment(string cardNumber, string cardHolderName, string expiryDate)
    {
        CardNumber = cardNumber;
        CardHolderName = cardHolderName;
        ExpiryDate = expiryDate;
    }
    
    public void ProcessPayment(decimal amount)
    {
        Console.WriteLine($"Processing credit card payment of {amount:C} for cardholder {CardHolderName}");
        // Logic to process credit card payment
    }
}