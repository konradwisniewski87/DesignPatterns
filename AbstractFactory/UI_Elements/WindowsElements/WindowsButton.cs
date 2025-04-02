using AbstractFactory.UI_Elements.Interfaces;

namespace AbstractFactory.UI_Elements.WindowsElements;

internal class WindowsButton : IButton
{
    public void Render()
    {
        Console.WriteLine("Render Windows button");
    }
    public void OnClick()
    {
        Console.WriteLine("OnClick Windows button");
    }
}   
