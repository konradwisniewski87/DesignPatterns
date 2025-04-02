using AbstractFactory.UI_Elements.Interfaces;
using AbstractFactory.UI_Elements.WindowsElements;

namespace AbstractFactory.UI_Elements;

internal class WindowsFactory : IUIElementFactory
{
    public IButton CreateButton()
    {
        return new WindowsButton();
    }

    public ICheckbox CreateCheckbox()
    {
        return new WindowsCheckbox();
    }

    public ITextbox CreateTextbox()
    {
        return new WindowsTextbox();
    }
}
