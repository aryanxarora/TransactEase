using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance_Shapes
{
    abstract class Shape
    {
        double width;
        double height;

        public Shape(double width, double height)
        {
            this.width = width;
            this.height = height;
        }

        public double getWidth()
        {
            return width;
        }

        public double getHeight()
        {
            return height;
        }

        public abstract double calculateArea();
        public abstract double calculatePerimeter();
    }

}
