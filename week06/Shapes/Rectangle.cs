using System;

public class Rectangle : Shape
{
    private double _length;
    private double _width;

    public Rectangle(string color, double length, double width) : base (color)
    {
        _length = length;
        _width = width;
    }
    public override double GetArea()
    {
        return _length * _width;
    }
    public override double GetPerimeter()
    {
        double lengthDouble = _length *2;
        double widthDouble = _width * 2;
        return lengthDouble + widthDouble;
    }
}