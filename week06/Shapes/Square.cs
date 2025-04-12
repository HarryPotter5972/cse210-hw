using System;
using System.Reflection.Metadata.Ecma335;

public class Square : Shape
{
    protected double _side;
    public Square(string color, double side) : base (color)
    {
        _side = side;
    }
    public override double GetArea()
    {
        return _side * _side;
    }
    public override double GetPerimeter()
    {
        return _side * 4;
    }
}