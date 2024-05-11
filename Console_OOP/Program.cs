using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Console_OOP
{
    internal class Program
    {
        static void Main(string[] args)
        {
            CoorporateCustomer customer1 = new CoorporateCustomer();
            customer1.id = 1;
            customer1.Name = "Test";
            customer1.Surname = "Test";
            customer1.TcNo = "654654886";
            customer1.CustomerNo = "6565";

            IndıvıdualCustomer customer2 = new IndıvıdualCustomer();
            customer2.CompanyName = "Google";
            customer2.vergiNo = "545465";

            CustomerManager customerManager1 = new CustomerManager();
            customerManager1.Add(customer1);
            customerManager1.Add(customer2);

            
        }
    }
}
