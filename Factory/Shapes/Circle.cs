namespace Factory.Shapes;

internal class Circle : IShape
{
    public int Width { get; set; }
    public int Height { get; set; }

    public void Draw()
    {
        Console.WriteLine("Render circle");
    }
}
