using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment1
{
    public class FarmersMarket
    {
        // id, name, kg, price
        private int id;
        private string name;
        private double weight;
        private double price;

        public FarmersMarket(int id, string name, double weight, double price)
        {
            this.id = id;
            this.name = name;
            this.weight = weight;
            this.price = price;
        }

        public int _id { get { return id; } set { this.id = value; } }
        public string _name { get { return name; } set { this.name = value; } }
        public double _weight { get { return weight; } set { this.weight = value; } }
        public double _price { get { return price; } set { this.price = value;  } }
    }
}
