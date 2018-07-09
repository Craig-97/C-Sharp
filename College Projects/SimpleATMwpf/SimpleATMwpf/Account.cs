using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;

namespace SimpleBank
{
    /// <summary>
    /// abstract base class for Account objects
    /// 
    /// static attribute num used to get next account number
    /// illustrates use of class attributes
    /// 
    /// holds common attributes acount number and balance
    /// implements Serializable
    /// developer: ferd fliintstone
    /// </summary>
    [Serializable]
    abstract public class Account
    {
        /// <summary>
        /// class attribute - note how can initialise
        /// </summary>
        static private long num = 0; 

        /// <summary>
        /// unique account number
        /// </summary>
        protected long number;
        /// <summary>
        /// balance in account
        /// </summary>
        protected decimal balance;
        /// <summary>
        /// list of Transactions
        /// </summary>
        List<Transaction> transactions;

        /// <summary>
        /// Number
        /// read only property for account number
        /// </summary>
        public long Number
        {
            get
            {
                return number;
            }
        }

        /// <summary>
        /// Balance
        /// read only property for balance
        /// </summary>
        public decimal Balance
        {
            get
            {
                return balance;
            }
        }

        /// <summary>
        /// GetTransactions
        /// read only property for list of transactions
        /// </summary>
        public List<Transaction> GetTransactions
        {
            get
            {
                return transactions;
            }
        }
        /// <summary>
        /// Constructor
        /// overriden sets balance to ammount
        /// number set to one more than value in static num
        /// creates new empty list for transactions
        /// </summary>
        /// <param name="amount">initial balance</param>
        public Account(decimal amount)
        {
            balance = amount;
            number = ++num;
            transactions = new List<Transaction>();
        }
        /// <summary>
        /// Default Constructor
        /// sets balance to 0
        /// number set to one more than value in static num
        /// creates new empty list for transactions
        /// </summary>
        public Account()
        {
            balance = 0;
            number = ++num;
            transactions = new List<Transaction>();
        }


        /// <summary>
        /// overidable debit method
        /// default debit subtracts value from balance
        /// creates new debitTransaction
        /// </summary>
        /// <param name="amount">amount to debit</param>
        public virtual void debit(decimal amount)
        {
            balance = balance - amount;
            transactions.Add(new DebitTransaction(balance,amount));
        }

        /// <summary>
        /// ceradit method
        /// adds amount to balance and then
        /// creates new CreditTransaction
        /// </summary>
        /// <param name="amount">amount to credit</param>
        public void credit(decimal amount)
        {
            balance = balance + amount;
            transactions.Add(new CreditTransaction(balance, amount));
        }

        /// <summary>
        /// returns a string representation of all
        /// Transactions for the account
        /// 
        /// real one would probably only go back a month or so!!!
        /// </summary>
        /// <returns></returns>
        public string getStatement()
        {
            transactions.Reverse();
            string strout = "Account: " + this.ToString()+"\n";
            foreach(Transaction t in transactions)
            {
                strout = strout + t + "\n";
            }     
            transactions.Reverse();
            return strout;
        }

        /// <summary>
        /// gets an array of strings showing most recent
        /// transaction first
        /// </summary>
        /// <returns>array of strings</returns>
        public string[] getTextStatement()
        {
            transactions.Reverse();
            
            //declare and iniitialise array of strings
            string[] outArray = new string[transactions.Count+1];
            int pos = 0;
            
            foreach (Transaction t in transactions)
            {
                outArray[pos++] = t.ToString() ;
            }
            transactions.Reverse();
            return outArray;
        }
        
        /// <summary>
        /// returns string reprsentation of last 31 days transactions
        /// illustrates some of the ways DateTime can be used
        /// </summary>
        /// <returns>string reprsentation of monthly statement</returns>
        public string getMonthlyStatement()
        {
            transactions.Reverse();
            string strout = "Account: " + this.ToString() + "\n";
            DateTime mth = DateTime.Now;
            mth = mth.Subtract(new TimeSpan(31,0,0,0));
            foreach (Transaction t in transactions)
            {
                if (t.Date.Month > mth.Month)
                strout = strout + t + "\n";
            }
            transactions.Reverse();
            return strout;
        }

        /// <summary>
        /// overriden ToString
        /// returns string representatiion of Account
        /// </summary>
        /// <returns>string reprssentation of Account</returns>
        public override string ToString()
        {
            string strout;
            strout = string.Format("Account num: {0}",number);
            strout = strout + string.Format(" Balance:{0:c}",balance);
            return strout;
        }

        /// <summary>
        /// writes full statement to text file
        /// 
        /// THROWS EXCEPTION if IO problem
        /// </summary>
        /// <param name="filename">filename</param>
        public void printStatement(string filename)
        {
            using (StreamWriter sw = new StreamWriter(filename))
            {
                // Add some text to the file.
                sw.WriteLine("Account " + number + " Statement");
                sw.WriteLine("-------------------");
                sw.WriteLine(DateTime.Now);
                transactions.Reverse();
                int count = 0;
                while (count < 5 && count < transactions.Count)
                {
                    Transaction t = transactions[count];
                    sw.WriteLine(t);
                    count++;
                }
                transactions.Reverse();
           
            }
        }
        
    }

    /// <summary>
    /// CreditAccount
    /// inherits from Account 
    /// has an additional overdraft limit
    /// implements Serializable
    /// </summary>
    [Serializable]
    public class CreditAccount : Account
    {
        /// <summary>
        /// overdraft limit
        /// </summary>
        private decimal ODLimit;

        /// <summary>
        /// Limit property
        /// can set/get overdraft limit
        /// </summary>
        public decimal Limit
        {
            get
            {
                return ODLimit;
            }
            set
            {
                ODLimit = value;
            }
        }
        
        /// <summary>
        /// creates a CreditAccount with balance in amount
        /// overdraft limit set to 100
        /// base sets account number
        /// </summary>
        /// <param name="amount">intitial balance</param>
        public CreditAccount(decimal amount):base(amount)
        {
            //the :base(amount) calls parent constructor
            //passes on parameter amount
            //so only need to initialise additional instance variables
            ODLimit = 100;
        }

        /// <summary>
        /// default constructor
        /// balance set to 0, limit to 100
        /// base also sets account number
        /// 
        /// </summary>
        public CreditAccount():base()
        {
            ODLimit = 100;
        }

        /// <summary>
        /// creates a CreditAccount with balance in amount
        /// overdraft limit set to limit
        /// base sets account number
        /// </summary>
        /// <param name="amount"></param>
        /// <param name="limit"></param>
        public CreditAccount(decimal amount,decimal limit): base(amount)
        {
            //the :base(amount) calls parent constructor
            //passes on parameter amount
            //so only need to initialise additional instance variables
            ODLimit = limit;
        }
    
        /// <summary>
        /// returns string representation of a CreditAccount object
        /// uses base ToString()
        /// </summary>
        /// <returns>string representation of a CreditAccount object</reurtns>
        public override string ToString()
        {
            string strout;
            strout = "Credit account " + base.ToString();
            strout = strout + string.Format("\n OD Limit:{0:c}", ODLimit);
            return strout;
        }

        /// <summary>
        /// overides debit method
        /// notice how base debit takes care of creating Transaction
        /// THROWS EXCEPTION if insufficient funds
        /// </summary>
        /// <param name="amount">amount to debit</param>
        public override void debit(decimal amount)
        {
            if (amount > (Balance + ODLimit))
                throw new Exception("Insufficient funds: transaction cancelled");
            else
                base.debit(amount);
        }
    }

    /// <summary>
    /// DepositAccount
    /// inherits from account with additional rate of interest attribute
    /// implements Serializable
    /// </summary>
    [Serializable]
    public class DepositAccount:Account
    {
        /// <summary>
        /// rate of interest
        /// </summary>
        private double rate;

        /// <summary>
        /// Rate property
        /// sets/gets rate of interest
        /// </summary>
        public double Rate
        {
            set
            {
                rate = value;
            }
            get
            {
                return rate;
            }
        }

        
        /// <summary>
        /// default constructor
        /// base sets balance to 0 and sets number to next available
        /// sets rate to 2.0
        /// </summary>
        public  DepositAccount():base()
        {
            rate = 2.0;
        }

        /// <summary>
        /// Constructor
        /// sets balance to amount and basesets number to next available
        /// sets rate to 2.0
        /// </summary>
        /// <param name="amount">initial balance</param>
        public DepositAccount(decimal amount) : base(amount)
        {
            rate = 2.0;
        }

        /// <summary>
        /// Constructor
        /// sets balance to amount and basesets number to next available
        /// sets rate to rt
        /// </summary>
        /// <param name="amount">intial balance</param>
        /// <param name="rt">inital rate of interest</param>
        public DepositAccount(decimal amount,double rt)   : base(amount)
        {
            rate = rt;
        }

        /// <summary>
        /// overidden debit method
        /// uses base debit method to create Transaction
        /// 
        /// THROWS EXCEPTION if insufficient funds
        /// </summary>
        /// <param name="amount"></param>
        public override void debit(decimal amount)
        {
            if (amount > balance)
                throw new Exception("Insufficient Funds: transaction cancelled");
            else
                base.debit(amount);
        }

        /// <summary>
        /// overidden ToString
        /// </summary>
        /// <returns>string representation of a DepositAccount</returns>
        public override string ToString()
        {
            string strout;
            strout = "Deposit account " + base.ToString();
            strout = strout + string.Format("\n Rate:{0:f2}", rate);
            return strout;
        }
    }
}
