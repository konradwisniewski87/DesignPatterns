namespace Prototype.Shapes;

internal class Triangle : Shape
{
    public override Shape clone(Shape shape)
    {
        return (Triangle)this.MemberwiseClone();
    }

    public override void render()
    {
        Console.WriteLine($"Render {GetType().Name}");
    }
}
