using System;

class Program
{
    static void Main(string[] args)
    {
        ShapeCalculator calculator = new ShapeCalculator();
        
        Console.WriteLine("Select the shape (circle, square, rectangle, triangle):");
        string shapeType = Console.ReadLine().ToLower();
        
        GeometricShape shape = null;

        switch (shapeType)
        {
            case "circle":
                Console.WriteLine("Enter the radius:");
                double radius = Convert.ToDouble(Console.ReadLine());
                shape = new Circle(radius);
                break;
            case "square":
                Console.WriteLine("Enter the side length:");
                double sideLength = Convert.ToDouble(Console.ReadLine());
                shape = new Square(sideLength);
                break;
            case "rectangle":
                Console.WriteLine("Enter the width:");
                double width = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("Enter the height:");
                double height = Convert.ToDouble(Console.ReadLine());
                shape = new Rectangle(width, height);
                break;
            case "triangle":
                Console.WriteLine("Enter the base length:");
                double baseLength = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("Enter the height:");
                double triangleHeight = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("Enter side A length:");
                double sideA = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("Enter side B length:");
                double sideB = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("Enter side C length:");
                double sideC = Convert.ToDouble(Console.ReadLine());
                shape = new Triangle(baseLength, triangleHeight, sideA, sideB, sideC);
                break;
            default:
                Console.WriteLine("Invalid shape type.");
                return;
        }

        Console.WriteLine("Select the calculation type (area, perimeter, volume):");
        string calculationType = Console.ReadLine().ToLower();

        calculator.Calculate(shape, calculationType);
    }
}

public abstract class GeometricShape
{
    public abstract double CalculateArea();
    public abstract double CalculatePerimeter();
    public abstract double CalculateVolume();
}

public class Circle : GeometricShape
{
    public double Radius { get; set; }

    public Circle(double radius)
    {
        Radius = radius;
    }

    public override double CalculateArea()
    {
        return Math.PI * Math.Pow(Radius, 2);
    }

    public override double CalculatePerimeter()
    {
        return 2 * Math.PI * Radius;
    }

    public override double CalculateVolume()
    {
        return 0; // Circle does not have a volume
    }
}

public class Square : GeometricShape
{
    public double SideLength { get; set; }

    public Square(double sideLength)
    {
        SideLength = sideLength;
    }

    public override double CalculateArea()
    {
        return Math.Pow(SideLength, 2);
    }

    public override double CalculatePerimeter()
    {
        return 4 * SideLength;
    }

    public override double CalculateVolume()
    {
        return 0; // Square does not have a volume
    }
}

public class Rectangle : GeometricShape
{
    public double Width { get; set; }
    public double Height { get; set; }

    public Rectangle(double width, double height)
    {
        Width = width;
        Height = height;
    }

    public override double CalculateArea()
    {
        return Width * Height;
    }

    public override double CalculatePerimeter()
    {
        return 2 * (Width + Height);
    }

    public override double CalculateVolume()
    {
        return 0; // Rectangle does not have a volume
    }
}

public class Triangle : GeometricShape
{
    public double BaseLength { get; set; }
    public double Height { get; set; }
    public double SideA { get; set; }
    public double SideB { get; set; }
    public double SideC { get; set; }

    public Triangle(double baseLength, double height, double sideA, double sideB, double sideC)
    {
        BaseLength = baseLength;
        Height = height;
        SideA = sideA;
        SideB = sideB;
        SideC = sideC;
    }

    public override double CalculateArea()
    {
        return 0.5 * BaseLength * Height;
    }

    public override double CalculatePerimeter()
    {
        return SideA + SideB + SideC;
    }

    public override double CalculateVolume()
    {
        return 0; // Triangle does not have a volume
    }
}

public class ShapeCalculator
{
    public void Calculate(GeometricShape shape, string calculationType)
    {
        switch (calculationType.ToLower())
        {
            case "area":
                Console.WriteLine($"Area: {shape.CalculateArea()}");
                break;
            case "perimeter":
                Console.WriteLine($"Perimeter: {shape.CalculatePerimeter()}");
                break;
            case "volume":
                double volume = shape.CalculateVolume();
                if (volume == 0)
                {
                    Console.WriteLine("Volume cannot be calculated for this shape.");
                }
                else
                {
                    Console.WriteLine($"Volume: {volume}");
                }
                break;
            default:
                Console.WriteLine("Invalid calculation type.");
                break;
        }
    }
}

