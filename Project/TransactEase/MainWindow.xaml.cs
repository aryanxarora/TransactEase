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
        DatabaseConnection DB = new DatabaseConnection();
        public List<Account> accList
        {
            get;
            set;
        }

        public MainWindow()
        {
            InitializeComponent();
            accList = DB.ReadAllAccounts();

            //CREATE ACCOUNT
            //Account account1 = new Account("Aryan Arora", "630 Rue William", "4388022227", "123456", 100000);
            //Account account2 = new Account("Jolson Eric Cruz", "288 Ave Grosvener", "4388022223", "123456", 12048);
            //Account account3 = new Account("Kiara Gelle", "106 Notre Dame", "4383232226", "98765", 230579);
            //DB.CreateAccount(account1);
            //DB.CreateAccount(account2);
            //DB.CreateAccount(account3);

            // READ ACCOUNT
            //Account account1 = DB.ReadAccount(591827);
            //Account account2 = DB.ReadAccount(591828);
            //accList.Add(account1);
            //accList.Add(account2);

            // DELETE ACCOUNT
            //DB.DeleteAccount(591828);

            DataContext = this;
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            OpenAccount oa = new OpenAccount();
            oa.Show();
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            accList = DB.ReadAllAccounts();
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
