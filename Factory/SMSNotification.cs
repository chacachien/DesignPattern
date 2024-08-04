namespace Factory;

public class SMSNotification:INotification
{
    public void Notify(string message)
    {
        Console.WriteLine($"Send SMS: {message}");
    }
}