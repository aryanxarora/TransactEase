using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance_Shapes
{
    class Square : Shape
    {
        public Square(double width) : base(width, width)
        {
            Console.WriteLine("Square Created!");
        }
        public override double calculateArea()
        {
            return Math.Pow(this.getWidth(), 2);
        }

        public override double calculatePerimeter()
        {
            return 4 * this.getWidth();
        }
    }
}
