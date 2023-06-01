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
    /// Interaction logic for ShippingChargesInterface.xaml
    /// </summary>
    public partial class ShippingChargesInterface : Window
    {
        public ShippingChargesInterface()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            double _weight = Double.Parse(weight.Text);
            ShippingCharges sc = new ShippingCharges(_weight);
            displayFees.SetValue(Label.ContentProperty, sc.calculateShippingCharge(Double.Parse(miles.Text)).ToString());
        }
    }
}
