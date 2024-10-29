using System;

class Program
{
    static void Main(string[] args)
    {
        List<Shape> shapes = new List<Shape>();

        shapes.Add(new Square(5, "bleu"));
        shapes.Add(new Rectangle(2, 4, "pink"));
        shapes.Add(new Circle(2.5, "black"));

        foreach (Shape shape in shapes)
            {
            double area = shape.GetArea();

            Console.WriteLine($"The color of the shape is {shape.GetColor()} and its area is {area}");

            }
    }
}