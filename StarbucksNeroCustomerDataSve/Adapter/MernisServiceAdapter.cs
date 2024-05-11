using StarbucksNeroCustomerDataSve.Abstract;
using StarbucksNeroCustomerDataSve.Entities;
using StarbucksNeroCustomerDataSve.MernisServiceReference1;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StarbucksNeroCustomerDataSve.Adapter
{
    public class MernisServiceAdapter : ICustomerCheckService
    {
        public bool CheckIfPerson(Customer customer)
        {
            KPSPublicSoapClient client = new KPSPublicSoapClient();
            return  client.TCKimlikNoDogrula(Convert.ToInt64(customer.NationalityId) , customer.name.ToUpper(),customer.lastname.ToUpper(),customer.DateofBirth.Year);
        }
    }
}
