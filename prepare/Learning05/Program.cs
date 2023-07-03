using System;

class Program
{
    static void Main(string[] args)
    {
        Square squ1 = new Square("Blue", 2.3);
        Rectangle rec1 = new Rectangle("Red", 1.3, 2.7);
        Circle cir1 = new Circle("Green", 2.4);

        List<Shape> shapes = new List<Shape>();
        shapes.Add(squ1);
        shapes.Add(rec1);
        shapes.Add(cir1);

        foreach (Shape shape in shapes)
        {
            string color = shape.GetColor();
            double area = shape.GetArea();

            Console.WriteLine($"The {color} shape has an area of {area}.");
        }        
    }
}