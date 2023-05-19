using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance_Shapes
{
    class Rectangle : Shape
    {
        public Rectangle(double width, double height) : base(width, height)
        {
            Console.WriteLine("Rectange Created!");
        }

        public override double calculateArea()
        {
            return this.getWidth() * this.getHeight();
        }


        public override double calculatePerimeter()
        {
            return 2 * (this.getWidth() + this.getHeight());
        }
    }
}
