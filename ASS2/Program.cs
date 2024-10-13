using ASS2.Customer_Notifications;
using ASS2.Media_Player_Plugins;
using ASS2.Payment_Methods;
using ASS2.Vehicle_Control_System;

namespace ASS2;

class Program
{
    static void Main(string[] args)
    {
        #region Payment Methods

        // Create a user
        User user = new User("John Doe");

        // Add payment methods
        user.AddPaymentMethod(new CreditCardPayment("1234-5678-9876-5432", "John Doe", "12/25"));
        user.AddPaymentMethod(new PayPalPayment("johndoe@example.com"));
        user.AddPaymentMethod(new BankTransferPayment("2323232", "CIB"));

        // User selects a payment method by index and makes payment
        user.MakePayment(0, 150.75m); // Use Credit Card
        user.MakePayment(1, 75.25m);  // Use PayPal

        #endregion
        
        #region Vehicle Control System

        // Create instances of different vehicles
        Vehicle car = new Car("Toyota Corolla", 4);
        Vehicle truck = new Truck("Ford F-150", 2.5f);
        Vehicle motorcycle = new Motorcycle("Harley Davidson", false);

        // Start, describe, and stop each vehicle
        car.Start();
        car.Describe();
        car.Stop();

        Console.WriteLine(); // Add space between outputs for readability

        truck.Start();
        truck.Describe();
        truck.Stop();

        Console.WriteLine(); // Add space between outputs for readability

        motorcycle.Start();
        motorcycle.Describe();
        motorcycle.Stop();

        #endregion
        
        #region Media Player Plugins

        MediaPlayer player = new MediaPlayer();

        // Add multiple media files
        player.AddMedia(new Audio());
        player.AddMedia(new Video());
        player.AddMedia(new Podcast());

        // Play all media files
        player.PlayAll();

        Console.WriteLine(); // Adding space for clarity

        // Stop all media files
        player.StopAll();

        #endregion
        
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