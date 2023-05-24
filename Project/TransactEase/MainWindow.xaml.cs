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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace TransactEase
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {

        public List<Account> accList
        {
            get;
            set;
        }
        public MainWindow()
        {
            InitializeComponent();
            //Bank bank = new Bank("CIBC");
            //bank.addAccount(new Account("Aryan Arora", "630 Rue William", "4388022227", "123456", 0));
            //bank._accounts[0].addTranscation(new Transcation("Ma Poule Mouille", 0, 17.99));
            //myLabel.SetValue(Label.ContentProperty, bank._accounts[0]._transactions[0].ToString());

            accList = new List<Account>();
            Account account1 = new Account("Aryan Arora", "630 Rue William", "4388022227", "123456", 100000);
            Account account2 = new Account("Jolson Eric Cruz", "288 Ave Grosvener", "4388022223", "123456", 12048);
            accList.Add(account1);
            accList.Add(account2);
            //myLabel.SetValue(Label.ContentProperty, accList[0]._transactions[0].ToString());
            DataContext = this;
        }
    }
}
