namespace Prototype.Shapes;

internal class Rectangle : Shape
{
    public override Shape clone(Shape shape)
    {
        Rectangle cloneBase = (Rectangle)this.MemberwiseClone();
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
