using System;

class Program
{
    static void Main(string[] args)
    {
        Square square = new Square("red", 4);
        // string squareColor = square.GetColor();
        // double squareArea = square.GetArea();
        // Console.WriteLine($"Square color: {squareColor}, Square area: {squareArea}");


        Rectangle rectangle = new Rectangle("yellow", 4, 5);
        // string rectangleColor = rectangle.GetColor();
        // double rectangleArea = rectangle.GetArea();
        // Console.WriteLine($"Rectangle color: {rectangleColor}, Rectangle area: {rectangleArea}");


        Circle circle = new Circle("blue", 25);
        // string circleColor = circle.GetColor();
        // double circleArea = circle.GetArea();
        // Console.WriteLine($"Circle color: {circleColor}, Circle area: {circleArea}");


        List<Shape> shapes = new List<Shape>();
        shapes.Add(square);
        shapes.Add(rectangle);
        shapes.Add(circle);

        foreach (Shape shape in shapes)
        {
            string color = shape.GetColor();
            double area = shape.GetArea();

            Console.WriteLine($"Color: {color}");
            Console.WriteLine($"Area: {area}");
        }
    }
}