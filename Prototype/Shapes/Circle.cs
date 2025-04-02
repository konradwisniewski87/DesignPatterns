namespace Prototype.Shapes;

internal class Circle : Shape
{
    public int Radius { get; set; }
    public override Shape clone(Shape shape)
    {
        Circle cloneBase = (Circle)this.MemberwiseClone();
        cloneBase.border = new Border()
        {
            Size = cloneBase.border.Size,
            Color = cloneBase.border.Color
        };
        return cloneBase;
    }

    public override void render()
    {
        Console.WriteLine($"Render {GetType().Name}");
    }
}
