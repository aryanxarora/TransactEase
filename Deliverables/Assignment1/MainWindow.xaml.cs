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
        public List<FarmersMarket> products
        {
            get;
            set;
        }
        public MainWindow()
        {
            InitializeComponent();

            products = DatabaseConnection.ReadProducts();

            DataContext = this;
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            products = DatabaseConnection.ReadProducts();
            productsList.ItemsSource = products;
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            AddProduct ap = new AddProduct();
            ap.Show();
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            FarmersMarket fm = (FarmersMarket)productsList.SelectedItem;
            DatabaseConnection.DeleteProduct(fm._id);
        }
    }
}
