namespace AbstractFactory;

public class MacFactory:GUIFactory
{
    public Button CreateButton() => new MacButton();

    public Box CreateBox() => new MacBox();
}