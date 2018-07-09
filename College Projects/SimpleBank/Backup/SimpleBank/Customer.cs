using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using People;

namespace SimpleBank
{
    [Serializable]
    public class Customer:Person
    {
        private CreditAccount creditAcc;
        private DepositAccount depositAcc;

        //add in public properties 

        public CreditAccount CreditAcc
        {
            get { return creditAcc; }
        }
        public DepositAccount DepositAcc
        {
            get { return depositAcc; }
        }

        //Constructor

        public Customer(string name)
            : base(name)
        {
            creditAcc = null;
            depositAcc = null;
        }

        public void createCredit(decimal b, decimal od)
        {
            creditAcc = new CreditAccount(b, od);
        }

        public void createDeposit(decimal b, double rate)
        {
            depositAcc = new DepositAccount(b, rate);
        }

        public override string ToString()
        {
            string strout = base.ToString();
            if (creditAcc != null)
                strout = strout + creditAcc;
            if (depositAcc != null)
                strout = strout + depositAcc;
            return strout;
        }

       
    }
}
