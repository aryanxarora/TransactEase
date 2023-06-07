using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TransactEase
{
    public class Transaction
    {
        private int id;
        private DateTime timestamp;
        private String description;
        private double credit;
        private double debit;

        public Transaction(int id, string description, double credit, double debit)
        {
            this.id = id;
            this.timestamp = DateTime.Now;
            this.description = description;
            this.credit = credit;
            this.debit = debit;

        }

        public int ID
        {
            get { return id; }
        }

        public DateTime Timestamp
        {
            get { return timestamp; }
        }

        public String Description
        {
            get { return description; }
        }

        public double Credit { get { return credit; } }
        public double Debit { get { return debit; } }

        public override string ToString()
        {
            return $"Transcation {id} [ {timestamp} \t {description} \t {credit} \t {debit} ]";
        }
    }
}
