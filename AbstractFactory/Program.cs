using AbstractFactory.UI_Elements;

Console.WriteLine("-------------------------------------------------------------------");
var winUiApplication = new Application(new WindowsFactory());
winUiApplication.RenderUI();

var macUiApplication = new Application(new MacFactory());
macUiApplication.RenderUI();


Console.WriteLine("-------------------------------------------------------------------");