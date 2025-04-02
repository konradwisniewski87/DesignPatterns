using AbstractFactory.UI_Elements.Interfaces;

namespace AbstractFactory.UI_Elements.MacElements;

internal class MacCheckbox : ICheckbox
{
    public void Render()
    {
        Console.WriteLine("Render Mac checkbox");
    }
    public void OnClick()
    {
        Console.WriteLine("OnClick Mac checkbox");
    }
}
