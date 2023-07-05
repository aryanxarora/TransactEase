using System.Windows;

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

            if (_accountNumber == 280900 && _password == "admin")
            {
                MainWindow ap = new MainWindow();
                ap.Show();
                this.Close();

            }
            else
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
