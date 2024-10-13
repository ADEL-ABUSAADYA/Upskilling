namespace ASS2.Payment_Methods;

public class User
{
    public string Name { get; set; }
    private List<IPaymentStrategy> paymentMethods = new List<IPaymentStrategy>();

    public User(string name)
    {
        Name = name;
    }

    // Method to add a new payment method
    public void AddPaymentMethod(IPaymentStrategy paymentStrategy)
    {
        paymentMethods.Add(paymentStrategy);
        Console.WriteLine($"{paymentStrategy.GetType().Name} added for {Name}.");
    }

    // Method to select a payment method by index and make a payment
    public void MakePayment(int paymentMethodIndex, decimal amount)
    {
        if (paymentMethodIndex < 0 || paymentMethodIndex >= paymentMethods.Count)
        {
            Console.WriteLine("Invalid payment method selected.");
        }
        else
        {
            Checkout checkout = new Checkout(paymentMethods[paymentMethodIndex]);
            checkout.ProcessOrder(amount);
        }
    }
}