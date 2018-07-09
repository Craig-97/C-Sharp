using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SimpleBank
{
    [Serializable]

    public class Bank
    {
        List<Customer> customers;
        
        public Bank()
        {
            customers = new List<Customer>();
        }

        public void addCustomer(Customer cus)
        {
            customers.Add(cus);
        }

        // Search predicate returns true Customer name matches s.
        private static bool testCust(Customer c,String s)
        {
            if (c.Name == s)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
       
        public Customer findCustomer(string sname)
        {
            foreach (Customer c in customers)
            {
                if (c.Name == sname)
                    return c;//found
            }
            return null;//not found

        } 
    }
}
