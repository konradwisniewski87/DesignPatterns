namespace Prototype.Shapes;

internal class Circle : Shape
{
    public int Radius { get; set; }
    public override Shape clone(Shape shape)
    {
        return (Circle)this.MemberwiseClone();
    }

    public override void render()
    {
        Console.WriteLine($"Render {GetType().Name}");
    }
}
