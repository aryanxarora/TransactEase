using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MVC_Calculator.Controller;
using MVC_Calculator.Model;

namespace MVC_Calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            controller ctr = new controller();
            ctr.model = new model(5, 5);

            Console.WriteLine(ctr.model.multiply());

            Console.ReadKey();
        }
    }
}
