namespace ASS2.Customer_Notifications;

public class NotificationService
{
    private List<INotifiable> _notifications;

    // Constructor to initialize the list of notifications
    public NotificationService()
    {
        _notifications = new List<INotifiable>();
    }

    // Method to add a notification type to the list
    public void AddNotification(INotifiable notifiable)
    {
        _notifications.Add(notifiable);
    }

    // Method to notify the customer through all added notification types
    public void NotifyCustomer(string message)
    {
        if (_notifications.Count == 0)
        {
            Console.WriteLine("No notification methods available.");
            return;
        }

        foreach (var notification in _notifications)
        {
            notification.SendNotification(message);
        }
    }
}