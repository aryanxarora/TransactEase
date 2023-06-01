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
    /// Interaction logic for DistanceTraveledInterface.xaml
    /// </summary>
    public partial class DistanceTraveledInterface : Window
    {
        public DistanceTraveledInterface()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            double _speed = Double.Parse(speed.Text);
            double _time = Double.Parse(time.Text);
            DistanceTraveled dt = new DistanceTraveled(_speed, _time);
            displayDistance.SetValue(Label.ContentProperty, dt.getDistance().ToString());
        }
    }
}
