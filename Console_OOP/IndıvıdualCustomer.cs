using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Console_OOP
{
    internal class IndıvıdualCustomer: Customer //miras alma -nerden +Customer sınıfından. 
    {
        public string CompanyName { get; set; }
        public string vergiNo { get; set; }
    }
}
