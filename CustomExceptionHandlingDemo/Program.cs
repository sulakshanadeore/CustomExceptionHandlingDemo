using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomExceptionHandlingDemo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            CustomerUtility u=new CustomerUtility();
            try
            {
                u.FindCustomer(1);
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
