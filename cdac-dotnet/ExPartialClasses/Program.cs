using System.Security.Authentication;
using System.Security.Cryptography.X509Certificates;

namespace ExPartialClasses
{

    public partial class Customer
    {
        partial void addedCustomer(string s);

        public void addingCustomer(string s) { 
            Console.WriteLine("Adding customer: "+s);
            addedCustomer(s);
        }



    }

    public partial class Customer {
        partial void addedCustomer(string s)
        {
            Console.WriteLine("Customer Added: "+s);
        }
       
    } 
    class Program
    {

        static void Main(string[] args)
        {

            Customer customer = new Customer();
            customer.addingCustomer("yadnyesh");

            Console.ReadKey();
            
        }
    }
}
