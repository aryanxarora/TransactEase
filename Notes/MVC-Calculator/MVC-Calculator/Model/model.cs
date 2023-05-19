using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVC_Calculator.Model
{
    class model
    {
        double var1;
        double var2;

        public model(double var1, double var2)
        {
            this.var1 = var1;
            this.var2 = var2;
        }

        public double add()
        {
            return var1 + var2;
        }

        public double subtract()
        {
            return var1 - var2;
        }

        public double multiply()
        {
            return var1 * var2;
        }

        public double divide()
        {
            try
            {
                return var1 / var2;
            }
            catch (DivideByZeroException e)
            {

                Console.WriteLine(e);
            }

            return 0;
        }
    }
}
