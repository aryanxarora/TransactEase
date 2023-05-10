using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance_Shapes
{
    class Circle : Shape
    {

        public Circle(double length) : base(length/2, length/2)
        {
            Console.WriteLine("Circle Created!");
        }
        public override double calculateArea()
        {
            return Math.PI * Math.Pow(this.getWidth(), 2);
        }

        public override double calculatePerimeter()
        {
            return 2 * Math.PI * this.getWidth();
        }
    }
}
