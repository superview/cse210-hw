using System.Drawing;
using System.Reflection.Metadata.Ecma335;

public class Square : Shape
{
    private double _side;
    public Square(string color, double side)
    {
        _color = color;
        _side = side;
        _shape = "square";
    }
        
    public override double GetArea()
    {
        return _side * _side;
    }
}