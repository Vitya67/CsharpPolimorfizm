using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Circle circle1 = new Circle("Круг1", 5);
            Circle circle2 = new Circle("Круг2", 3);
            Square square1 = new Square("Квадрат1", 4);
            Square square2 = new Square("Квадрат2", 6);

            Console.WriteLine("Інформація про фігури:");
            Console.WriteLine($"Фігура: {circle1.Name}, Площа: {circle1.Area()}, Периметр: {circle1.Perimeter()}");

            Square maxSquare = square1.Area() > square2.Area() ? square1 : square2;
            Circle maxCircle = circle1.Area() > circle2.Area() ? circle1 : circle2;

            Console.WriteLine($"Площа найбільшого квадрата: {maxSquare.Area()}");
            Console.WriteLine($"Площа найбільшого кола: {maxCircle.Area()}");
        }
    }
    public abstract class Shape
    {
        private string name;

        public Shape(string name)
        {
            this.name = name;
        }

        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        public abstract double Area();
        public abstract double Perimeter();
    }
    public class Circle : Shape
    {
        public double radius;
        public Circle(string name, double radius) : base(name)
        {
            this.radius = radius;
        }

        public override double Area()
        {
            return 3.14 * radius * radius;
        }
        public override double Perimeter()
        {
            return 2 * 3.14 * radius;
        }
    }
    public class Square : Shape
    {
        public double side;
        public Square(string name, double side) : base(name)
        {
            this.side = side;
        }

        public override double Area()
        {
            return side * side;
        }
        public override double Perimeter()
        {
            return 4 * side;
        }
    }

}