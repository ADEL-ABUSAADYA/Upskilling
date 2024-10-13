namespace ASS2.Customer_Notifications;

public class SmsNotifiable : INotifiable
{
    public void SendNotification(string message)
    {
        Console.WriteLine($"Sending SMS: {message}");
    }
}

