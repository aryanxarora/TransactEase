using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Inheritance_Shapes;

namespace Inheritance_Shapes
{
    class Program
    {
        static void Main(string[] args)
        {
            Rectangle rectangle = new Rectangle(5, 10);
            Console.WriteLine("Rectangle Area = " + rectangle.calculateArea());
            Console.WriteLine("Rectangle Perimeter = " + rectangle.calculatePerimeter());

            Console.WriteLine();
            Square square = new Square(3);
            Console.WriteLine("Square Area = " + square.calculateArea());
            Console.WriteLine("Square Perimiter = " + square.calculatePerimeter());

            Console.WriteLine();
            Circle circle = new Circle(10);
            Console.WriteLine("Circle Area = " + circle.calculateArea());
            Console.WriteLine("Circle Perimiter = " + circle.calculatePerimeter());

            Console.ReadKey();
        }
    }
}