using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab1
{
    class ShippingCharges
    {
        private double weight;

        public ShippingCharges(double weight)
        {
            this.weight = weight;
        }

        public double _weight { 
            get { return weight; } 
            set { weight = value; } 
        }

        public double getShippingRate()
        {
            if(weight <= 2)
            {
                return 1.10;
            }
            else if (weight > 2 && weight <= 6)
            {
                return 2.20;
            }
            else if(weight > 6 && weight <= 10)
            {
                return 3.70;
            }
            else
            {
                return 4.80;
            }            
        }

        public double calculateShippingCharge(double miles)
        {
            return getShippingRate() * (int)Math.Ceiling(miles / 500);
        }
    }
}
