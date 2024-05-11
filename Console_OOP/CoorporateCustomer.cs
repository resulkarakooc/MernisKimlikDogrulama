using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Console_OOP
{
    internal class CoorporateCustomer:Customer //miras alma -nerden +Customer sınıfından. 
    {
        public string Name { get; set; }
        public string Surname { get; set; }
        public string TcNo { get; set; }
    }
}
