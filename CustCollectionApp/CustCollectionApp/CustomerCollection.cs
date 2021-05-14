using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustCollectionApp
{
    public class CustomerCollection
    {
        
            private Customer[] customers;
            private int noCustomers;

            public CustomerCollection()
            {
            customers = new Customer[10];
            noCustomers = 0;
            }

        //Find – Given the first name and last name of a customer, this method finds the
        //contact phone number of the customer from the data structure.
        public int Find(string lastname, string firstname)
        {
            Customer aCustomer = new Customer(lastname, firstname, 0);
            for (int i = 0; i < noCustomers; i++)
                if (customers[i].CompareTo(aCustomer) == 0)
                    return customers[i].Mobile;
            return 0;
        }


        //Insert – Given the first name, last name and contact phone number of a
        //customer, this method inserts this customer into the data structure.
        public void Insert(string lastname, string firstname, int mobile)
        {
            Customer aCustomer = new Customer(lastname, firstname, mobile);
            customers[noCustomers] = aCustomer;
            noCustomers++;
        }


        //Insert – This method inserts an object of Customer class into the data
        //structure.


        //Delete – Given the first name and last name of a customer, this method
        //removes the customer out of the data structure.
        public void Delete(string lastname, string firstname)
        {
            Customer aCustomer = new Customer(lastname, firstname, 0);
            int i = 0;
            while ((i < noCustomers) && (customers[i].CompareTo(aCustomer) != 0))
                i++;
            if (i == noCustomers)
                Console.WriteLine("The customer does not exist!");
            else
            {
                for (int j = i + 1; j < noCustomers; j++)
                    customers[j - 1] = customers[j];
                noCustomers--;
            }
        }


        //Display – This method displays the information about all the customers in the
        //data structure.
        public void Display()
        {
            for(int i = 0; i < noCustomers; i++)
            {
                Console.WriteLine(customers[i]);
            }
        }

    }
    }

