namespace ASS2.Payment_Methods;

public class Checkout
{
    private IPaymentStrategy _paymentStrategy;
    
    // Constructor accepting the chosen payment strategy
    public Checkout(IPaymentStrategy paymentStrategy)
    {
        _paymentStrategy = paymentStrategy;
    }
    
    public void ProcessOrder(decimal amount)
    {
        Console.WriteLine("Starting payment process...");
        _paymentStrategy.ProcessPayment(amount);
        Console.WriteLine("Payment process completed.");
    }
}