namespace Prototype.Shapes;

internal class Rectangle : Shape
{
    public override Shape clone(Shape shape)
    {
        return (Rectangle)this.MemberwiseClone();
    }

    public override void render()
    {
        Console.WriteLine($"Render {GetType().Name}");
    }
}
