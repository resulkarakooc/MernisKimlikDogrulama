
using StarbucksNeroCustomerDataSve.Abstract;
using StarbucksNeroCustomerDataSve.Adapter;
using StarbucksNeroCustomerDataSve.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StarbucksNeroCustomerDataSve
{
    internal class Program
    {
        static void Main(string[] args)
        {
            BaseCustomerManager customer1 = new StarbucksCustomerManager(new MernisServiceAdapter());
            customer1.Save(new Entities.Customer { name = "Resul", lastname = "Karakoç", DateofBirth = new DateTime(2003, 2, 28), id = 1, NationalityId = "51040403949" }); ;
            Console.ReadLine();
        }
    }
}
