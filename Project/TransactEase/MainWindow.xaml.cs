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
            DatabaseConnection DB = new DatabaseConnection();

            //accList = DB.ReadAllAccounts();

            //CREATE ACCOUNT
            //Account account1 = new Account("Aryan Arora", "630 Rue William", "4388022227", "123456", 100000);
            //Account account2 = new Account("Jolson Eric Cruz", "288 Ave Grosvener", "4388022223", "123456", 12048);
            //DB.CreateAccount(account1);
            //DB.CreateAccount(account2);

            // READ ACCOUNT
            Account account1 = DB.ReadAccount(591827);
            Account account2 = DB.ReadAccount(591828);
            accList.Add(account1);
            accList.Add(account2);

            // DELETE ACCOUNT
            //DB.DeleteAccount(591828);

            DataContext = this;
        }
    }
}
