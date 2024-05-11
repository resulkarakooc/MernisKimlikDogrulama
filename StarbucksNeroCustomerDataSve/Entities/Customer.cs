using StarbucksNeroCustomerDataSve.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StarbucksNeroCustomerDataSve.Entities
{
    public class Customer:IEntity
    {
        public int id { get; set; }
        public string name { get; set; }
        public string lastname { get; set; }
        public DateTime DateofBirth { get; set; }
        public string NationalityId { get; set; }
    }
}
