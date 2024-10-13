namespace ASS2.Payment_Methods;

public class PayPalPayment : IPaymentStrategy
{
    public string Email { get; set; }
    
    public PayPalPayment(string email)
    {
        Email = email;
    }
    
    public void ProcessPayment(decimal amount)
    {
        Console.WriteLine($"Processing PayPal payment of {amount:C} to {Email}");
        // Logic to process PayPal payment
    }
}