namespace AbstractFactory;

public class WindowButton:Button
{
    public override void Print()
    {
        Console.WriteLine($"Window Button {width}");
    }
}