using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab1
{
    class Population
    {
        private double numOrganisms;
        private double averageIncrease;
        private int daysMultiply;

        public Population(double numOrganisms, double averageIncrease, int daysMultiply)
        {
            this.numOrganisms = numOrganisms;
            this.averageIncrease = averageIncrease;
            this.daysMultiply = daysMultiply;
        }

        public void displayPopulation()
        {
            double temp = numOrganisms;
            for(int i = 0; i < daysMultiply; i++)
            {
                Console.WriteLine("Day: " + (i + 1) + " Population: " + temp);
                temp = temp + (temp * (averageIncrease / 100));
            }
        }
    }
}
