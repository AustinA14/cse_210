using System;

class Program
{
    static void Main(string[] args)
    {
        List<Shape> shapeList = new List<Shape>();
        Square square1 = new Square(6.5, "blue");
        Rectangle rectangle1 = new Rectangle(3, 7, "green");
        Circle circle1 = new Circle(7, "red");
        shapeList.Add(square1);
        shapeList.Add(rectangle1);
        shapeList.Add(circle1);
        foreach(Shape shape in shapeList)
        {
            Console.WriteLine($"Color: {shape.GetColor()}");
            Console.WriteLine($"Area: {shape.GetArea()}");
        }
    }
}