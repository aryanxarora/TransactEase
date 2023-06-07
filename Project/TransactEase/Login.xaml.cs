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
    /// Interaction logic for Login.xaml
    /// </summary>
    public partial class Login : Window
    {
        public Login()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            int _accountNumber = int.Parse(accountNumber.Text);
            string _password = password.Text;

            if(_accountNumber == 0000 && _password == "admin")
            {
                MainWindow ap = new MainWindow();
                ap.Show();
                this.Close();

            } else
            {
                Account account = DatabaseConnection.ReadAccount(_accountNumber);
                if (account == null)
                {
                    MessageBox.Show("Error", "Account Not Found!");
                }
                else
                {
                    if (account.Password == _password)
                    {
                        ManageAccount ma = new ManageAccount(account);
                        ma.Show();
                        this.Close();
                    }
                }
            }
        }
    }
}
