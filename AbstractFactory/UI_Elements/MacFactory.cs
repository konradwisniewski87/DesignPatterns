using AbstractFactory.UI_Elements.Interfaces;
using AbstractFactory.UI_Elements.MacElements;

namespace AbstractFactory.UI_Elements;

internal class MacFactory : IUIElementFactory
{
    public IButton CreateButton()
    {
        return new MacButton();
    }

    public ICheckbox CreateCheckbox()
    {
        return new MacCheckbox();
    }

    public ITextbox CreateTextbox()
    {
        return new MacTextbox();
    }
    
}
