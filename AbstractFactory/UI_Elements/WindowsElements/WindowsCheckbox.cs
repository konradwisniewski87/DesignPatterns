using AbstractFactory.UI_Elements.Interfaces;

namespace AbstractFactory.UI_Elements.WindowsElements;

internal class WindowsCheckbox : ICheckbox
{
    public void Render()
    {
        Console.WriteLine("Render Windows checkbox");
    }
    public void OnClick()
    {
        Console.WriteLine("OnClick Windows checkbox");
    }
}
