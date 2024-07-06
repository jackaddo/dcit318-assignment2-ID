using System;

// Define an abstract class called Shape
abstract class Shape
{
    // Declare an abstract method GetArea()
    public abstract double GetArea();
}

// Create a derived class Circle
class Circle : Shape
{
    // Properties for circle radius
    public double Radius { get; set; }

    // Implement the GetArea() method for circle
    public override double GetArea()
    {
        return Math.PI * Math.Pow(Radius, 2);
    }
}

// Create another derived class Rectangle
class Rectangle : Shape
{
    // Properties for rectangle length and width
    public double Length { get; set; }
    public double Width { get; set; }

    // Implement the GetArea() method for rectangle
    public override double GetArea()
    {
        return Length * Width;
    }
}

class Program
{
    static void Main()
    {
        // Create an instance of Circle
        Circle circle = new Circle { Radius = 5.0 };
        double circleArea = circle.GetArea();
        Console.WriteLine($"Circle area: {circleArea:F2}");

        // Create an instance of Rectangle
        Rectangle rectangle = new Rectangle { Length = 4.0, Width = 6.0 };
        double rectangleArea = rectangle.GetArea();
        Console.WriteLine($"Rectangle area: {rectangleArea:F2}");
    }
}
