namespace Prototype.Shapes;

internal abstract class Shape
{
    public int x { get; set; }
    public int y { get; set; }
    public Border border { get; set; }

    public abstract void render();
    public abstract Shape clone(Shape shape);

}
