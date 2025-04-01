namespace Factory.Shapes;

internal class ShapeFactory
{
    public IShape CreateShape(ShapeType shapeType)
    {
        return shapeType switch
        {
            ShapeType.Circle => new Circle(),
            ShapeType.Rectangle => new Rectangle(),
            ShapeType.Triangle => new Triangle(),
            _ => throw new ArgumentOutOfRangeException(nameof(shapeType), shapeType, null)
        };
    }   
}
