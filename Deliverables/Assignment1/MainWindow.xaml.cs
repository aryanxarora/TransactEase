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
            products = new List<FarmersMarket>();
            productsList.ItemsSource = products;

            DatabaseConnection.UpdateProduct(new FarmersMarket("Apple", 23, 2.1));
            DatabaseConnection.UpdateProduct(new FarmersMarket("Orange", 20, 2.49));
            DatabaseConnection.UpdateProduct(new FarmersMarket("Raspberry", 25, 2.35));
            DatabaseConnection.UpdateProduct(new FarmersMarket("Blueberry", 29, 1.45));
            DatabaseConnection.UpdateProduct(new FarmersMarket("Cauliflower", 24, 2.22));

            DataContext = this;
        }

        private void refreshProducts()
        {
            productsList.ItemsSource = products;
            productsList.Items.Refresh();
            DataContext = this;
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            List<FarmersMarket> inventory = DatabaseConnection.ReadProducts();
            int choice = selectProduct.SelectedIndex;
            double purchase = Double.Parse(weight.Text);
            if (inventory != null && inventory[choice]._weight < purchase)
            {
                MessageBox.Show("Inventory is low cannot make purchase", "Sorry!");
            } else
            {
                FarmersMarket item = new FarmersMarket(inventory[choice]._name, purchase, inventory[choice]._price * purchase);
                products.Add(item);
                double sum = Double.Parse(totalPrice.Content.ToString());
                sum += inventory[choice]._price * purchase;
                totalPrice.SetValue(Label.ContentProperty, sum);
                DatabaseConnection.UpdateProduct(new FarmersMarket(inventory[choice]._name, inventory[choice]._weight - purchase, inventory[choice]._price));
                refreshProducts();
            }
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            AddProduct ap = new AddProduct();
            ap.Show();
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            FarmersMarket fm = (FarmersMarket)productsList.SelectedItem;
            DatabaseConnection.DeleteProduct(fm._name);
        }
    }
}
