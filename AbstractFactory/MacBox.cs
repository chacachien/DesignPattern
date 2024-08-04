namespace AbstractFactory;

public class MacBox:Box
{
    public override void Print()
    {
        Console.WriteLine($"Max Box {width}");
    }
}