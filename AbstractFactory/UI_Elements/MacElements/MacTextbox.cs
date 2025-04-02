using AbstractFactory.UI_Elements.Interfaces;

namespace AbstractFactory.UI_Elements.MacElements;

internal class MacTextbox : ITextbox
{
    public void HandleInput()
    {
        Console.WriteLine("Mac Textbox HandleInput");
    }

    public void Render()
    {
        Console.WriteLine("Mac Textbox Render");
    }
}
