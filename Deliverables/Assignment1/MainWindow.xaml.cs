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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Assignment1
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public List<FarmersMarket> products = new List<FarmersMarket>();
        public List<FarmersMarket> Products
        {
            get { return products;  }
            set { products = value; }
        }
        public MainWindow()
        {
            InitializeComponent();

            products.Add(new FarmersMarket(1, "Apple", 23, 2.10));
            products.Add(new FarmersMarket(2, "Orange", 20, 2.49));
            products.Add(new FarmersMarket(3, "Raspberry", 25, 2.35));
            products.Add(new FarmersMarket(4, "Blueberry", 29, 1.45));
            products.Add(new FarmersMarket(5, "Cauliflower", 24, 2.22));

            DataContext = this;
        }
    }
}
