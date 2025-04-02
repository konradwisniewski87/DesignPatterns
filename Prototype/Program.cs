using Prototype.Shapes;

Console.WriteLine("-------------------------------------------------------------------");
Circle circle = new Circle()
{
    x = 10,
    y = 20,
    Radius = 30,
    border = new Border()
    {
        Color = "Blue",
        Size = "2px"
    }
};

Circle circle2 = (Circle)circle.clone(circle);

var referenceEquals = ReferenceEquals(circle, circle2);
var borderReferenceEquals = ReferenceEquals(circle.border, circle2.border);
Console.WriteLine($"ReferenceEquals: {referenceEquals}, border reference equals: {borderReferenceEquals}");



Console.WriteLine("-------------------------------------------------------------------");