using Factory.Shapes;

Console.WriteLine("-------------------------------------------------------------------");
var ShapeFactory = new ShapeFactory();
var circle = ShapeFactory.CreateShape(ShapeType.Circle);

circle.Draw();




Console.WriteLine("-------------------------------------------------------------------");