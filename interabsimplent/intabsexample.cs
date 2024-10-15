using System;


namespace intabsexample
{
    public abstract class Shape
    {
        public abstract double CalculateArea();

        public void Display()
        {

            Console.WriteLine("The area of the given shape is " + CalculateArea());
        }
    }

    public class Circle : Shape
    {
        private double radius;

        public Circle(double radius)
        {
            this.radius = radius;
        }

        public override double CalculateArea()
        {
            return Math.PI * radius * radius;
        }
    }

    public class Rectangle : Shape
    {
        private double length;
        private double width;

        public Rectangle(double length, double width)
        {
            this.length = length;
            this.width = width;
        }

        public override double CalculateArea()
        {
            return length * width;
        }
    }

    class intabsexample
    {
        static void Main(string[] args)
        {
            Shape golo = new Circle(50);
            golo.Display();

            Shape chauda = new Rectangle(20, 10);
            chauda.Display();
        }
    }
}