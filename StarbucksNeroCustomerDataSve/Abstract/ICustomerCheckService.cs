﻿using StarbucksNeroCustomerDataSve.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StarbucksNeroCustomerDataSve.Abstract
{
    public  interface ICustomerCheckService
    {
        bool CheckIfPerson(Customer customer);
    }
}
