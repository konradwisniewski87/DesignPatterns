using AbstractFactory.UI_Elements.Interfaces;

namespace AbstractFactory.UI_Elements.MacElements;

internal class MacButton : IButton
{
    public void Render()
    {
        Console.WriteLine("Render Mac button");
    }
    public void OnClick()
    {
        Console.WriteLine("OnClick Mac button");
    }
}
