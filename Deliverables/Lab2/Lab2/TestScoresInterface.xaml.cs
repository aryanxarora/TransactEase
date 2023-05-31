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
    /// Interaction logic for TestScoresInterface.xaml
    /// </summary>
    public partial class TestScoresInterface : Window
    {
        public TestScoresInterface()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            double _score1 = Double.Parse(score1.Text);
            double _score2 = Double.Parse(score2.Text);
            double _score3 = Double.Parse(score3.Text);
            TestScores ts = new TestScores(_score1, _score2, _score3);
            displayAvg.SetValue(Label.ContentProperty, ts.getAverage().ToString());
            displayLetter.SetValue(Label.ContentProperty, ts.getLetterGrade());
        }
    }
}
