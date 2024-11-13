using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomExceptionHandlingDemo
{
    
    internal class Program
    {
        internal static event RemoveCustomerDelegate ev_CustomerDeletion;
        internal static event CustomerGreetingsDelegate ev_Customers;

        static void Main(string[] args)
        {
            CustomerUtility u=new CustomerUtility();
            try
            {
                Console.WriteLine("Menu 1 to find, 2 to  delete customer 3.Multicast delegate");
                int ch=Convert.ToInt32(Console.ReadLine());
                switch (ch)
                {
                    case 1:
                        u.FindCustomer(1);
                        break;
                    case 2:
                        RemoveCustomerDelegate del = new RemoveCustomerDelegate(u.DeleteCustomer);
                        ev_CustomerDeletion += del;

                        Console.WriteLine("Enter the customer id to delete");
                        int custid=Convert.ToInt32(Console.ReadLine());
                       ev_CustomerDeletion(custid);

                        break;
                    case 3:

                        CustomerGreetingsDelegate[] delArray = new CustomerGreetingsDelegate[] {
                        u.GreetEveryCustomer,
                        u.PrintCustomers
                        };
                        //CustomerGreetingsDelegate del1=new CustomerGreetingsDelegate(u.GreetEveryCustomer);
                        //CustomerGreetingsDelegate del2 = new CustomerGreetingsDelegate(u.PrintCustomers);
                        //CustomerGreetingsDelegate del3=(CustomerGreetingsDelegate)MulticastDelegate.Combine(del1, del2);


                        CustomerGreetingsDelegate del3 = (CustomerGreetingsDelegate)MulticastDelegate.Combine(delArray);
                        //del3();
                        ev_Customers += del3;
                        ev_Customers();


                        break;
                    default:
                        break;
                }
                
                





            }
            catch (CustomerNotFoundException ex)
            {

                Console.WriteLine(ex.Message);
            }
            catch (Exception ex) {

                Console.WriteLine(ex.Message);
            
            }
            
            Console.ReadLine();


        }
    }
}
