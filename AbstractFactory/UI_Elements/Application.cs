namespace AbstractFactory.UI_Elements;

internal class Application
{
    private IUIElementFactory _uiElementFactory;
    public Application(IUIElementFactory uiElementFactory)
    {
        _uiElementFactory = uiElementFactory;
    }
    public void RenderUI()
    {
        var createNewFileButton = _uiElementFactory.CreateButton();
        createNewFileButton.Render();

        var textBox = _uiElementFactory.CreateTextbox();
        textBox.Render();

        var checkBox = _uiElementFactory.CreateCheckbox();
        checkBox.Render();
    }
}
