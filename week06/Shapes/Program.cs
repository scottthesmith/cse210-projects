using System;
using System.Globalization;

class Program
{
    static void Main(string[] args)
    {
        List<Shape> shapes = new List<Shape>();

        Square square = new Square("blue", 4);
        shapes.Add(square);
  
            
        Rectangle rectangle = new Rectangle(4,5,"red");
        shapes.Add(rectangle);
        
        Circle circle = new Circle(6, "brown");
        shapes.Add(circle);

        foreach (Shape shape in shapes)
        {
            string color = shape.GetColor();
            double area = shape.GetArea();
            Console.WriteLine($"The {color} shape has an area of {area}.");
        }
        
    }
}