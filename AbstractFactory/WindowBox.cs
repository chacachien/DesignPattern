namespace AbstractFactory;

public class WindowBox:Box
{
    public override void Print()
    {
        Console.WriteLine($"Window box {width}");
    }
}