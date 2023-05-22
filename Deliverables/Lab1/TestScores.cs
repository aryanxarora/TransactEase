using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab1
{
    class TestScores
    {
        private double score1;
        private double score2;
        private double score3;

        public TestScores(double score1, double score2, double score3)
        {
            this.score1 = score1;
            this.score2 = score2;
            this.score3 = score3;
        }

        public double _Score1 
        {
            get { return score1; }
            set { score1 = value; } 
        }

        public double _Score2
        {
            get { return score2; }
            set { score2 = value; }
        }

        public double _Score3
        {
            get { return score3; }
            set { score3 = value; }
        }

        public double getAverage()
        {
            return (score1 + score2 + score3) / 3;
        }

        public char getLetterGrade()
        {
            double avg = getAverage();
            if(avg <= 100 && avg >= 90)
            {
                return 'A';
            } 
            else if (avg <= 89 && avg >= 80)
            {
                return 'B';
            } 
            else if (avg <= 79 && avg >= 70)
            {
                return 'C';
            }
            else if (avg <= 69 && avg >= 60)
            {
                return 'D';
            } else
            {
                return 'F';
            }
        }
    }
}
