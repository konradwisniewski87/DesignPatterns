namespace Factory.Shapes;

internal interface IShape
{
    public int Width { get; set; }
    public int Height { get; set; }
    public abstract void Draw();
}
