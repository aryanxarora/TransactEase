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

namespace Lab2
{
    /// <summary>
    /// Interaction logic for BankChargesInterface.xaml
    /// </summary>
    public partial class BankChargesInterface : Window
    {
        public BankChargesInterface()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            double _balance = Double.Parse(balance.Text);
            int _checks = int.Parse(checks.Text);
            BankCharges bc = new BankCharges(_balance, _checks);
            displayFees.SetValue(Label.ContentProperty, bc.calculateMonthlyFees().ToString());
        }
    }
}
