namespace AbstractFactory;

public class MacButton:Button
{
    public override void Print()
    {
        Console.WriteLine($"Mac Button {width}");
    }
}