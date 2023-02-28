using System;

class Program
{
    static void Main(string[] args)
    {

        List<Shape> shapes = new List<Shape>();

        Square square = new Square("square", "red", 13);
        shapes.Add(square);

        Rectangle rectangle = new Rectangle("rectangle", "purple", 10, 7);
        shapes.Add(rectangle);

        Circle circle = new Circle("circle", "orange", 3);
        shapes.Add(circle);


        foreach (Shape shape in shapes)
        {
            Console.WriteLine($"The area of the {shape.GetColor()} {shape.GetName()} is {shape.GetArea()}.");

        }

    }
}