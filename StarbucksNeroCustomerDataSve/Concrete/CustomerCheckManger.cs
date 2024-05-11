using StarbucksNeroCustomerDataSve.Abstract;
using StarbucksNeroCustomerDataSve.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StarbucksNeroCustomerDataSve.Concrete
{
    internal class CustomerCheckManger : ICustomerCheckService
    {
        public bool CheckIfPerson(Customer customer)
        {
            return true;
        }
    }
}
