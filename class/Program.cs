class Program
{
    static void Main()
    {
        // Example usage
        Circle circle = new Circle(5);  // Create a circle with radius 5
        Square square = new Square(4);  // Create a square with side length 4

        // Print the area and perimeter of the circle
        Console.WriteLine("Circle Area: " + circle.Area());
        Console.WriteLine("Circle Perimeter: " + circle.Perimeter());

        // Print the area and perimeter of the square
        Console.WriteLine("Square Area: " + square.Area());
        Console.WriteLine("Square Perimeter: " + square.Perimeter());
    }
}