namespace Prototype.Shapes;

internal class Triangle : Shape
{
    public override Shape clone(Shape shape)
    {
        Triangle cloneBase = (Triangle)this.MemberwiseClone();
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
