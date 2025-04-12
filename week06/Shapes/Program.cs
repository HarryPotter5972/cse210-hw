using System;
using System.Runtime.InteropServices;

class Program
{
    static void Main(string[] args)
    {
        List<Shape> shapes = new List<Shape>();

        Square shapeOne = new Square("indigo", 25);
        shapes.Add(shapeOne);

        Rectangle shapeTwo = new Rectangle("purple", 50, 25);
        shapes.Add(shapeTwo);

        Circle shapeThree = new Circle("red", 5972);
        shapes.Add(shapeThree);

        foreach (Shape shape in shapes)
        {
            string color = shape.GetColor();
            double area = shape.GetArea();
            double perimeter = shape.GetPerimeter();

            Console.WriteLine($"The shape that is the color {color} has an area of {area} and a perimeter of {perimeter}");
        }
    }
}