using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


namespace SimpleBank
{
    /// <summary>
    /// Customer class
    /// holds customer details
    /// inherits from class People.Person
    /// implements serializable
    /// developer: fred flintsone
    /// date: jan 2015
    /// 
    /// Customers have unique names in this simple scenario
    /// </summary>
    [Serializable]
    public class Customer:People.Person
    {
        
        /// <summary>
        /// customer can have up to one credit account
        /// null if no credit account
        /// </summary>
        private CreditAccount creditAcc;
        /// <summary>
        /// customer can have up to one Deposit Account
        /// null if no deposit Account
        /// </summary>
        private DepositAccount depositAcc;

       
        /// <summary>
        /// read only property for Credit Account attribute
        /// </summary>
        public CreditAccount CreditAcc
        {
            get { return creditAcc; }
        }

        /// <summary>
        /// read only property for Deposit Account
        /// </summary>
        public DepositAccount DepositAcc
        {
            get { return depositAcc; }
        }

        
        /// <summary>
        /// overriden constructor
        /// Customers name set to name
        /// both credit and deposit accounts set to null
        /// </summary>
        /// <param name="name">name of customer</param>
        public Customer(string name)
            : base(name)
        {
            creditAcc = null;
            depositAcc = null;
        }


     
        /// <summary>
        /// createCredit
        /// used to allow a Customer to take out a credit account
        /// </summary>
        /// <param name="b">balance to set account to</param>
        /// <param name="od">overdraft limit for account</param>
        public void createCredit(decimal b, decimal od)
        {
            creditAcc = new CreditAccount(b, od);
        }

        /// <summary>
        /// createDeposit
        /// used to allow a customer to take out a deposit account
        /// </summary>
        /// <param name="b">balance to set account to</param>
        /// <param name="rate">rate of interest</param>
        public void createDeposit(decimal b, double rate)
        {
            depositAcc = new DepositAccount(b, rate);
        }

        /// <summary>
        /// overriden ToString
        /// returns string representation of Bank Customer
        /// the name of the customer
        /// </summary>
        /// <returns>name of customer</returns>
        public override string ToString()
        {
            
            return Name;
        }

       
    }
}
