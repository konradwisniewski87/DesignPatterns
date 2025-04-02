using AbstractFactory.UI_Elements.Interfaces;

namespace AbstractFactory.UI_Elements;

internal interface IUIElementFactory
{
    IButton CreateButton();
    ITextbox CreateTextbox();
    ICheckbox CreateCheckbox();
}
