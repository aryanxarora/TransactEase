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
    public partial class ManageAccount : Window
    {
        public List<Transaction> transactions
        {
            get;
            set;
        }
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

            transactions = new List<Transaction>();
            transactions.Add(new Transaction(1, "Payment received", 100.00, 0.00));
            transactions.Add(new Transaction(2, "Online purchase", 0.00, 50.00));
            transactions.Add(new Transaction(3, "Salary deposit", 2000.00, 0.00));
            transactions.Add(new Transaction(4, "Utility bill payment", 0.00, 75.00));
            transactions.Add(new Transaction(5, "Restaurant bill", 45.50, 0.00));
            transactions.Add(new Transaction(6, "Withdrawal from ATM", 0.00, 100.00));
            transactions.Add(new Transaction(7, "Online transfer", 250.00, 0.00));
            transactions.Add(new Transaction(8, "Credit card payment", 0.00, 200.00));
            transactions.Add(new Transaction(9, "Interest earned", 50.00, 0.00));
            transactions.Add(new Transaction(10, "Loan repayment", 0.00, 500.00));
            transactions.Add(new Transaction(11, "Grocery shopping", 80.00, 0.00));
            transactions.Add(new Transaction(12, "Gasoline purchase", 0.00, 35.00));
            transactions.Add(new Transaction(13, "Rent payment", 0.00, 1000.00));
            transactions.Add(new Transaction(14, "Restaurant bill", 65.00, 0.00));
            transactions.Add(new Transaction(15, "Online subscription", 0.00, 10.00));
            transactions.Add(new Transaction(16, "Electricity bill payment", 0.00, 50.00));
            transactions.Add(new Transaction(17, "Insurance premium", 120.00, 0.00));
            transactions.Add(new Transaction(18, "Medical expenses", 0.00, 75.50));
            transactions.Add(new Transaction(19, "Salary deposit", 2500.00, 0.00));
            transactions.Add(new Transaction(20, "Charitable donation", 0.00, 50.00));
            transactions.Add(new Transaction(21, "Shopping spree", 200.00, 0.00));
            transactions.Add(new Transaction(22, "Phone bill payment", 0.00, 45.00));
            transactions.Add(new Transaction(23, "Car maintenance", 85.00, 0.00));
            transactions.Add(new Transaction(24, "Online purchase", 0.00, 75.00));
            transactions.Add(new Transaction(25, "Interest earned", 10.00, 0.00));
            transactions.Add(new Transaction(26, "Dinner with friends", 75.00, 0.00));
            transactions.Add(new Transaction(27, "Loan repayment", 0.00, 500.00));
            transactions.Add(new Transaction(28, "Vacation booking", 500.00, 0.00));
            transactions.Add(new Transaction(29, "Gym membership", 0.00, 30.00));
            transactions.Add(new Transaction(30, "Stock investment", 1000.00, 0.00));

            DataContext = this;
        }

        private void deposit_Click(object sender, RoutedEventArgs e)
        {
            if(amount.Text == "" || amount.Text == "0")
            {
                MessageBox.Show("Enter Amount!", "Error");
            } else
            {
                Double changeamount = Double.Parse(amount.Text);
                account.AccountBalance = account.AccountBalance + changeamount;
                customerBalance.SetValue(Label.ContentProperty ,"$" + account.AccountBalance);
                transactions.Add(new Transaction(31, "Deposit", changeamount, 0.00));
                DatabaseConnection.UpdateAccount(account);
            }
            
        }

        private void withdraw_Click(object sender, RoutedEventArgs e)
        {
            if (amount.Text == "" || amount.Text == "0")
            {
                MessageBox.Show("Enter Amount!", "Error");
            }
            else
            {
                Double changeamount = Double.Parse(amount.Text);
                account.AccountBalance = account.AccountBalance - changeamount;
                customerBalance.SetValue(Label.ContentProperty, "$" + account.AccountBalance);
                transactions.Add(new Transaction(32, "Withdraw", 0.00, changeamount));
                DatabaseConnection.UpdateAccount(account);
            }
        }
    }
}
