using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab1
{
    class AverageRainfall
    {
        private int numYears;

        public AverageRainfall(int numYears)
        {
            this.numYears = numYears;
        }

        public int _NumYears { 
            get { return numYears; } 
            set { numYears = value; }
        }

        public void generateReport()
        {
            double totalRainfall = 0;
            for(int i = 1; i <= numYears; i++)
            {
                for(int j = 1; j <= 12; j++)
                {
                    Console.Write($"Enter inches of rainfall for Year {i} Month {j}: ");
                    totalRainfall += Double.Parse(Console.ReadLine());
                }
            }

            Console.WriteLine($"Total Months: {numYears * 12}");
            Console.WriteLine($"Total Inches of Rainfall: {totalRainfall}");
            Console.WriteLine($"Average Rainfall: {totalRainfall / (numYears * 12)}");
        }
    }
}
