namespace Factory;

public class EmailNotification: INotification
{
    public void Notify(string message)
    {
        Console.WriteLine($"Sending EMAIL: {message}");
    }
}