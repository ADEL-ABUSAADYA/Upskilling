namespace ASS2.Customer_Notifications;

public class EmailNotifiable : INotifiable
{
    public void SendNotification(string message)
    {
        Console.WriteLine($"Sending Email: {message}");
    }
}

