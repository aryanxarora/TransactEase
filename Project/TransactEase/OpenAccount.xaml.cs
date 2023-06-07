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

        DatabaseConnection DB = new DatabaseConnection();
        public OpenAccount()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            string name = customerName.Text;
            string address = customerAddress.Text;
            string phone = customerPhone.Text;
            string sin = customerSIN.Text;
            Account account = new Account(name, address, phone, sin, 0);
            DB.CreateAccount(account);
        }
    }
}
