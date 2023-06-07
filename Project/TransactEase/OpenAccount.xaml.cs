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

namespace TransactEase
{
    /// <summary>
    /// Interaction logic for OpenAccount.xaml
    /// </summary>
    public partial class OpenAccount : Window
    {
        public OpenAccount()
        {
            InitializeComponent();
        }

        private int generateAccountNumber()
        {
            List<Account> accList = DatabaseConnection.ReadAllAccounts();
            Random rand = new Random();
            int generatedNumber = rand.Next(10000, 100000);
            while(accList.Any(acc => acc.AccountNumber == generatedNumber))
            {
                generatedNumber = rand.Next(10000, 100000);
            }
            return generatedNumber;
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            string name = customerName.Text;
            string address = customerAddress.Text;
            string phone = customerPhone.Text;
            string sin = customerSIN.Text;
            string password = customerPassword.Text;
            Account account = new Account(generateAccountNumber(), name, address, phone, sin, password, 0);
            DatabaseConnection.CreateAccount(account);
        }
    }
}
