namespace AbstractFactory;

public class WinFactory:GUIFactory
{
    public Button CreateButton() => new WindowButton();

    public Box CreateBox() => new WindowBox();
}