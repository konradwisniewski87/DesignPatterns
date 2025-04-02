using AbstractFactory.UI_Elements.Interfaces;

namespace AbstractFactory.UI_Elements.WindowsElements;

internal class WindowsTextbox : ITextbox
{
    public void HandleInput()
    {
        Console.WriteLine("Windows Textbox HandleInput");
    }

    public void Render()
    {
        Console.WriteLine("Windows Textbox Render");
    }
}
