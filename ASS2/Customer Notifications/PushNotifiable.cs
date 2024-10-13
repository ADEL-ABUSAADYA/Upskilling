namespace ASS2.Customer_Notifications;

public class PushNotifiable : INotifiable
{
    public void SendNotification(string message)
    {
        Console.WriteLine($"Sending Push Notification: {message}");
    }
}