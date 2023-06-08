using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace Assignment1
{
    /// <summary>
    /// Interaction logic for AddProduct.xaml
    /// </summary>
    public partial class AddProduct : Window
    {
        public AddProduct()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Random rand = new Random();
            int id = rand.Next(1000000, 9999999);
            string _name = name.Text;
            double _weight = Double.Parse(weight.Text);
            double _price = Double.Parse(price.Text);
            FarmersMarket fm = new FarmersMarket(id, _name, _weight, _price);
            DatabaseConnection.AddProduct(fm);
        }
    }
}
