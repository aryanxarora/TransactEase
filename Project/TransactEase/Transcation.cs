using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TransactEase
{
    class Transcation
    {
        private static int serialGen = 192837465;
        private int id;
        private DateTime timestamp;
        private String description;
        private double credit;
        private double debit;

        public Transcation(string description, double credit, double debit)
        {
            this.id = serialGen;
            serialGen++;
            this.timestamp = DateTime.Now;
            this.description = description;
            this.credit = credit;
            this.debit = debit;
        }

        public override string ToString()
        {
            return $"Transcation {id} [ {timestamp} \t {description} \t {credit} \t {debit} ]";
        }
    }
}
