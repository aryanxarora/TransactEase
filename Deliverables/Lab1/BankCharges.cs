using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab1
{
    class BankCharges
    {
        private readonly double fixedCharge = 10;
        private readonly double overdraftFees = 15;
        private double endingBalance;
        private int checks;

        public BankCharges()
        {
            this.endingBalance = 0;
            this.checks = 0;
        }

        public BankCharges(double endingBalance, int checks)
        {
            this.endingBalance = endingBalance;
            this.checks = checks;
        }

        public double _FixedCharge { get { return fixedCharge; } }
        public double _OverdraftFees { get { return overdraftFees; } }

        public double _EndingBalance {
            get { return endingBalance;  }
            set { endingBalance = value; } 
        }
        public int _Checks
        {
            get { return checks; }
            set { checks = value; }
        }

        public double getCheckFees()
        {
            if(checks >= 60)
            {
                return 0.04;
            }
            else if(checks >= 40 && checks <= 59)
            {
                return 0.06;
            }
            else if(checks >= 20 && checks <= 39)
            {
                return 0.08;
            }
            else
            {
                return 0.10;
            }
        }

        public double calculateMonthlyFees()
        {
            double fees = _FixedCharge;
            fees += getCheckFees();
            if(_EndingBalance < 400)
            {
                fees += _OverdraftFees;
            }

            return fees;
        }

    }
}
