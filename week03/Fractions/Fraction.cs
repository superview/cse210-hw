using System;

public class Fraction
{
    private int _numerator;
    private int _denominator;

    public Fraction()
    {
        _numerator = 1;
        _denominator = 1;
    }
    public Fraction(int num)
    {
        _numerator = num;
        _denominator = 1;
    }
    public Fraction(int num, int den)
    {
        _numerator = num;
        _denominator = den;
    }

    public void SetNumerator(int num)
    {
        _numerator = num;
    }
    public void SetDenominator(int num)
    {
        _denominator = num;
    }
    public int GetNumerator()
    {
        return _numerator;
    }
    public int GetDenominator()
    {
        return _denominator;
    }
    public double GetQuotient()
    {
        // Prevent divide by zero
        if (_denominator != 0)
        {
            return (double)_numerator / _denominator;
        }
        else
        {
            // This is a bad idea to return false double
            // But I don't know how to raise exceptions yet.
            return 0.0;
        }
    }
    public string GetFractionString()
    {
        return _numerator + "/" + _denominator;
    }

    public double GetDecimalValue()
    {
        return GetQuotient();
    }
}