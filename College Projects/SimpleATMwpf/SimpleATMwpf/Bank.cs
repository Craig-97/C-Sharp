using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;


namespace SimpleBank
{

    /// <summary>
    /// Bank Class is the orchestrating instance for a
    /// Simple Bank.The Bank holds a list of customers. Each Customer
    /// can have a CreditAccount and DepositAccount
    /// 
    /// Note: in SimpleBank each Customer must have a unique name!
    /// <para>Author Fred Flintstone</para>
    /// <para>Date: Nov 2009</para>
    /// </summary>
    ///
    
    public class Bank
    {
        /// <summary>
        /// singleton instance
        /// </summary>
        private static Bank theBank;
        /// <summary>
        /// read only static property for
        /// singleton instance
        /// </summary>
        public static Bank Instance
        {
            get
            {
                if (theBank==null)
                {
                    theBank = new Bank();
                    theBank.populate();
                }
                return theBank;
            }
        }
        
        
        /// <summary>
        /// Instance Variables
        /// customers a List that holds the Banks Customers
        /// </summary>
        private List<Customer> customers;

        /// <summary>
        /// get property that returns list of Customers
        /// </summary>
        public List<Customer> Customers
        {
            get { return customers; }
        }
        
        /// <summary>
        /// Constructor overriden default constructor
        /// </summary>
        public Bank()
        {
            customers = new List<Customer>();
        }

        /// <summary>
        /// Method addCustomer will add a Customer to Bank
        /// Customer must be created before it is added
        /// </summary>
        /// <param name="cus"> Customer to add to bank</param>
        public void addCustomer(Customer cus)
        {
            customers.Add(cus);
        }

        /// <summary>
        /// listCustomers returns a string that contains the 
        /// names of all the customers in the Bank
        ///
        /// </summary>
        /// <returns> string with all customer names on new lines</returns>
        public string listCustomers()
        {
            string strout = "Customers\n";
            foreach (Customer c in customers)
                strout = strout + "\n" +c.Name;
            return strout;
        }

        /// <summary>
        /// method populate is used for testing and adds a set of
        /// dummy Customers to the Bank
        /// </summary>
        public void populate()
        {
            Customer fred = new Customer("Fred");
            fred.createCredit(500, 100);
            fred.CreditAcc.debit(300);
            fred.CreditAcc.debit(200);
            fred.CreditAcc.credit(100);
            
            Customer sam = new Customer("Sam");
             sam.createDeposit(700, 10);
            sam.DepositAcc.debit(300);
            sam.DepositAcc.debit(150);
            sam.DepositAcc.credit(100);
            sam.createCredit(600,50);
            sam.CreditAcc.debit(300);
            sam.CreditAcc.debit(200);
            sam.CreditAcc.credit(100);

            Customer tim = new Customer("Tim");
            tim.createDeposit(200, 10);
            tim.DepositAcc.debit(100);
            tim.DepositAcc.credit(150);
            tim.DepositAcc.credit(100);

            customers.Add(sam);
            customers.Add(tim);
            customers.Add(fred);
        }
        
       
        /// <summary>
        /// The findCustomer method uses a linear search to 
        /// find the first Customer with the name in the paramater sname.
        /// If found it returns the Customer with that name, otherwise returns null
        ///
        /// </summary>
        /// <param name="sname">name of customer to find</param>
        /// <returns>Customer searched for or null if not found</returns>
        public Customer findCustomer(string sname)
        {
            foreach (Customer c in customers)
            {
                if (c.Name == sname)
                    return c;//found
            }
            return null;//not found

        } 

        /// <summary>
        /// will serialize the customer list to a binary file
        /// THROWS EXCEPTION if IO error
        /// </summary>
        /// <param name="filename">filename</param>
        public void writeToFile(string filename)
        {
            IFormatter formatter = new BinaryFormatter();
            
            Stream stream = new FileStream(filename,
                 FileMode.Create, FileAccess.Write, FileShare.None);
            formatter.Serialize(stream, customers);
            stream.Close();

        }
        /// <summary>
        /// will deserialize the customer list from a binary file
        /// THROWS EXCEPTION if IO error
        /// </summary>
        /// <param name="filename">filename</param>
        public void readFromFile(string filename)
        {
            IFormatter nformatter = new BinaryFormatter();
            
            Stream nstream = new FileStream(filename,
               FileMode.Open, FileAccess.Read, FileShare.Read);
            customers = (List<Customer>)nformatter.Deserialize(nstream);
            nstream.Close();
        }

        
    }
}
