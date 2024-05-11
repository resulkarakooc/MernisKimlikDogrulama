﻿using StarbucksNeroCustomerDataSve.Abstract;
using StarbucksNeroCustomerDataSve.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace StarbucksNeroCustomerDataSve.Concrete
{
    public class StarbucksCustomerManager : BaseCustomerManager
    {
        private ICustomerCheckService _customerCheckService;

        public StarbucksCustomerManager(ICustomerCheckService customerCheckService)
        {
            _customerCheckService = customerCheckService;
        }

        public override void Save(Customer customer)
        {
            if (_customerCheckService.CheckIfPerson(customer))
            { 
                base.Save(customer);
            }
            else
            {
                
                Console.WriteLine("TC Vatandaş veri tabanında böyle biri yok");
                //throw new Exception("kişi doğrulanamadı");
            }


        }
    }
}
