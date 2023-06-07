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
    /// Interaction logic for ManageAccount.xaml
    /// </summary>
    public partial class ManageAccount : Window
    {
        private Account account;
        public ManageAccount(Account a)
        {
            InitializeComponent();
            this.account = a;
            accountNumber.SetValue(Label.ContentProperty, ("(#" + account.AccountNumber + ")"));
            customerName.SetValue(Label.ContentProperty, account.CustomerName);
            customerAddress.SetValue(Label.ContentProperty, account.CustomerAddress);
            customerPhone.SetValue(Label.ContentProperty, account.CustomerPhone);
            customerSIN.SetValue(Label.ContentProperty, account.CustomerSIN);
            customerBalance.SetValue(Label.ContentProperty, ("$" + account.AccountBalance));
        } 
    }
}
