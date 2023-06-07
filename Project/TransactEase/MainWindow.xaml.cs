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
using MongoDB.Driver;
using MongoDB.Bson;


namespace TransactEase
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public List<Account> accList
        {
            get;
            set;
        }

        public MainWindow()
        {
            InitializeComponent();
            accList = DatabaseConnection.ReadAllAccounts();

            DataContext = this;
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            OpenAccount oa = new OpenAccount();
            oa.Show();
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            accList = DatabaseConnection.ReadAllAccounts();
            accountsList.ItemsSource = accList;
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            Account selected = (Account)accountsList.SelectedItem;
            if(selected == null)
            {
                MessageBox.Show("Please Select Account");
            } else
            {
                ManageAccount ma = new ManageAccount(selected);
                ma.Show();
            }
        }
    }
}
