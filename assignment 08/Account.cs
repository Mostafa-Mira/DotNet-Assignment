using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace assignment_08
{
    internal struct Account
    {
        private int AccountId;
        private string AccountHolder;
        private double Balance;

        public int AccountId1
        {
            get { return AccountId; }
            set { AccountId = value; }
        }

        public string AccountHolder1
        {
            get { return AccountHolder; }
            set { AccountHolder = value; }
        }

        public double Balance1
        {
            get { return Balance; }
            set { Balance = value; }
        }
    }
}
