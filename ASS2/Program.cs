using ASS2.Customer_Notifications;

namespace ASS2;

class Program
{
    static void Main(string[] args)
    {
        #region Customer notification

        // Create a notification service
        NotificationService notificationService = new NotificationService();

        // Add different notification types
        notificationService.AddNotification(new EmailNotifiable());
        notificationService.AddNotification(new SmsNotifiable());
        notificationService.AddNotification(new PushNotifiable());

        // Notify the customer through all available channels
        notificationService.NotifyCustomer("Your order has been shipped!");

        #endregion
    }
}