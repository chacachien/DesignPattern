namespace Factory;

class Program
{
    static void Main(string[] args)
    {
        NotificationFactory factory = null;

        string notificationType = args[0];
        switch (notificationType)
        {
            case "email":
                factory = new EmailNotificationFactory();
                break;
            case "sms":
                factory = new SMSNotificationFactory();
                break;
            default:
                throw new NotImplementedException();
        }

        var notification = factory.CreateNotification();
        notification.Notify(args[1]);
    }
}