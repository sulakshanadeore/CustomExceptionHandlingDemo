using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomExceptionHandlingDemo
{
    internal delegate void RemoveCustomerDelegate(int custid);

    internal delegate void CustomerGreetingsDelegate();
    internal class Customer
    {
        public int Custid { get; set; }
        public string CustName { get; set; }
    }

    

    internal class CustomerUtility
    {
        

        static List<Customer> list = new List<Customer>() 
        { new Customer {Custid=1,CustName="Ankit" },
            new Customer {Custid=2,CustName="Gauri" },
            new Customer {Custid=3,CustName="Sumit" }

            };




        internal void GreetEveryCustomer()
        {
            foreach (var item in list)
            {
                Console.WriteLine("Good morning " +  item.CustName);
            }
        }


        internal void PrintCustomers()
        {
            foreach (var item in list)
            {
                Console.WriteLine(item.Custid + " " + item.CustName);
            }

        }


        internal void DeleteCustomer(int custid)
        {
            Customer found = list.Find(c => c.Custid == custid);
            if (found!=null)
            {
                list.Remove(found);


                Console.WriteLine("After deleting the following customers exists:");
                foreach (var item in list)
                {
                    Console.WriteLine(item.Custid + " " + item.CustName);
                }
            }
            else
            {
                throw new CustomerNotFoundException("This is not a valid customer id....");
            }

        }





      internal  void FindCustomer(int custid)
        { 
        Customer found=list.Find(c=>c.Custid==custid);
            if (found != null)
            {
                Console.WriteLine(found.Custid);
                Console.WriteLine(found.CustName);
            
            
            }
            else
            {
                throw new CustomerNotFoundException("This  customerid doesnot exists...");
            }
        
        }
    }
}
