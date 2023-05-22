using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Lab1
{
    class Program
    {
        static void Main(string[] args)
        {
            // DISTANCE TRAVELEED
            DistanceTraveled dt = new DistanceTraveled(40, 1);
            for(int i = 0; i < 3; i++)
            {
                Console.WriteLine("Hour: " + dt._TravelTime + " Distance Travelled: " + dt.getDistance());
                dt._TravelTime = dt._TravelTime + 1;
            }
            Console.WriteLine();

            // POPULATION INCREASE
            Population p = new Population(100, 30, 20);
            p.displayPopulation();
            Console.WriteLine();

            // AVERAGE RAINFALL
            AverageRainfall ar = new AverageRainfall(1);
            ar.generateReport();

            Console.ReadKey();
        }
    }
}
