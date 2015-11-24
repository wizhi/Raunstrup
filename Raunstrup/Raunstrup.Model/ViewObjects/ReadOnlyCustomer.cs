﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Raunstrup.Model.ViewObjects
{
    public class ReadOnlyCustomer
    {
        private readonly Customer _customer;

        public ReadOnlyCustomer(Customer customer)
        {
            _customer = customer;
        }

        public string Name { get { return _customer.Name; } }

        public string SteetName { get { return _customer.SteetName; } }

        public string StreetNumber { get { return _customer.StreetNumber; } }

        public string City { get { return _customer.City; }}

        public string PostalCode { get { return _customer.PostalCode; } }
    }
}
