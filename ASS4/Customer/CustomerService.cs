namespace ASS4;

public class CustomerService
{
    public static void PerformActionOnCustomers(List<Customer> customers, Action<Customer> action)
    {
        foreach (var customer in customers)
        {
            action(customer);
        }
    }

    public static void PrintCustomerDetails(Customer customer)
    {
        Console.WriteLine($"Name: {customer.Name}, Mobile: {customer.Mobile}, Email: {customer.Email}");
    }

    public static void SendWelcomeEmail(Customer customer)
    {
        Console.WriteLine($"Sending welcome email to {customer.Email}");
    }
}
