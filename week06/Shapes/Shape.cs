public abstract class Shape
{
    protected string _color = "Blue";
    protected string _shape;
    public string GetColor()
    {
        return _color;
    }
    public void SetColor(string color)
    {
        _color = color;
    }
    public abstract double GetArea();
    public string GetShape()
    {
        return _shape;
    }
}