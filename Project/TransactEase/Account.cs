using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace TransactEase
{
    public class Account
    {
        private static int serialGen = 591827;
        private int accountNumber;
        private String customerName;
        private String customerAddress;
        private String customerPhone;
        private String customerSIN;
        private double accountBalance;
        //private List<Transcation> transactions = new List<Transcation>();

        public Account(string customerName, string customerAddress, string customerPhone, string customerSIN, double accountBalance)
        {
            this.accountNumber = serialGen;
            serialGen++;
            this.customerName = customerName;
            this.customerAddress = customerAddress;
            this.customerPhone = customerPhone;
            this.customerSIN = customerSIN;
            this.accountBalance = accountBalance;
        }

        public Account(int accountNumber, string customerName, string customerAddress, string customerPhone, string customerSIN, double accountBalance)
        {
            this.accountNumber = accountNumber;
            this.customerName = customerName;
            this.customerAddress = customerAddress;
            this.customerPhone = customerPhone;
            this.customerSIN = customerSIN;
            this.accountBalance = accountBalance;
        }

        public int AccountNumber { get { return accountNumber; }}
        public String CustomerName
        {
            get { return customerName; }
            set { customerName = value; }
        }
        public String CustomerAddress
        {
            get { return customerAddress; }
            set { customerAddress = value; }
        }
        public String CustomerPhone
        {
            get { return customerPhone; }
            set { customerPhone = value; }
        }
        public String CustomerSIN
        {
            get { return customerSIN; }
            set { customerSIN = value; }
        }
        public double AccountBalance
        {
            get { return accountBalance; }
        }
    }
}
