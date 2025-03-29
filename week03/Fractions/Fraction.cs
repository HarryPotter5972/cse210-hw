using System;
using System.Diagnostics;
using System.Dynamic;

public class Fraction()
{
    private int _top;
    private int _bottom;

    public void BuildFraction()
    {
        _top = 1;
        _bottom = 1;
    }
    public void BuildFraction(int wholeNumber)
    {
        _top = wholeNumber;
        _bottom = 1;
    }
    public void BuildFraction(int top, int bottom)
    {
        _top = top;
        _bottom = bottom;
    }
    public int GetNumerator();
    {
        int numerator = _top;
        return numerator;
    }
    public int SetNumerator(int top)
    {


    }
    
    public string FractionString()
    {
        string fraction = $"{_top}/{_bottom}";
        return fraction;
    }
    public double DecimalValue()
    {
        return (double)_top / (double)_bottom;
    }
}