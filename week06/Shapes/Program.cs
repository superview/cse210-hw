using System;
using System.Globalization;

class Program
{
    static void Main(string[] args)
    {
        // List<Shape> shapes = new List<Shape>();
        List<Shape> shapes = [];
        Console.WriteLine("Hello World! This is the Shapes Project.");
        Shape square = new Square("Yellow", 12);
        shapes.Add(square);
        Shape rectangle = new Rectangle("Orange", 12, 18.225);
        shapes.Add(rectangle);
        Shape circle = new Circle("Blue", 32.88);
        shapes.Add(circle);

        foreach (Shape s in shapes)
        {
            Console.WriteLine($"Shape: {s.GetShape()}, Color: {s.GetColor()},  Area: {s.GetArea():F5}");
        }
    }
}