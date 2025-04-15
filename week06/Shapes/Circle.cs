public class Circle : Shape
{
    private double _radius;

    public Circle(string color, double radius)
    {
        _color = color;
        _radius = radius;
        _shape = "circle";
    }


    public override double GetArea()
    {
        return 3.14159 * _radius * _radius;
    }
}