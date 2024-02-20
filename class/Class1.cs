using System;

// Base class for shapes
public class Shape
{
    // Virtual methods that will be overridden by derived classes
    public virtual double Area()
    {
        return 0;
    }

    public virtual double Perimeter()
    {
        return 0;
    }
}

// Circle class, derived from Shape
public class Circle : Shape
{
    private double radius;  // Private field to store the radius

    // Constructor to initialize the circle with a given radius
    public Circle(double radius)
    {
        this.radius = radius;
    }

    // Override the Area method to calculate the area of the circle
    public override double Area()
    {
        return Math.PI * Math.Pow(radius, 2);
    }

    // Override the Perimeter method to calculate the perimeter (circumference) of the circle
    public override double Perimeter()
    {
        return 2 * Math.PI * radius;
    }
}

// Square class, derived from Shape
public class Square : Shape
{
    private double sideLength;  // Private field to store the side length

    // Constructor to initialize the square with a given side length
    public Square(double sideLength)
    {
        this.sideLength = sideLength;
    }

    // Override the Area method to calculate the area of the square
    public override double Area()
    {
        return Math.Pow(sideLength, 2);
    }

    // Override the Perimeter method to calculate the perimeter of the square
    public override double Perimeter()
    {
        return 4 * sideLength;
    }
}