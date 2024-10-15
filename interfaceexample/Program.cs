using System;

interface IShape
{
    double calculateArea();
}

public class Circle : IShape
{
    private double radius;


    public Circle (double radius)
    {
        this.radius = radius;
;    }

    
    public double calculateArea()
    {
        return Math.PI * radius * radius;
    }

}

public class Rectangle : IShape
{
    private double length;
    private double width;

    public Rectangle (double length, double width)
    {
        this.length = length;
        this.width = width;
    }

    public double calculateArea()
    {
        return length * width;
    }
}

class Program
{
    static void Main(string[] args)
    {
        IShape circle = new Circle(5);
        Console.WriteLine("The area of the Circle is " + circle.calculateArea());


        IShape rectangle = new Rectangle(20, 30);
        Console.WriteLine("The area of the rectangle is " + rectangle.calculateArea());
    }
}
