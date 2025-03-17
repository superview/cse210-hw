using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the Fractions Project.");
        Fraction f1 = new Fraction();
        Fraction f2 = new Fraction(6);
        Fraction f3 = new Fraction(6, 7);
        Console.WriteLine($"first one: {f1.GetQuotient()}");
        Console.WriteLine($"second one: {f2.GetQuotient()}");
        Console.WriteLine($"third one: {f3.GetQuotient()}");

        Console.WriteLine($"first one: {f1.GetFractionString()}");
        Console.WriteLine($"second one: {f2.GetFractionString()}");
        Console.WriteLine($"third one: {f3.GetFractionString()}");

        Console.WriteLine($"first one: {f1.GetDecimalValue()}");
        Console.WriteLine($"second one: {f2.GetDecimalValue()}");
        Console.WriteLine($"third one: {f3.GetDecimalValue()}");

    }
}