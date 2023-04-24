﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataObjects;

namespace LogicLayerInterfaces
{
    public interface ICustomerManager
    {
        List<Customer> GetAllActiveCustomers();

        bool AddCustomer(string fName, string lName, string phone, string email, int Zip);

        bool AddCustomer(Customer customer);

        bool RemoveCustomer(int custID);

        bool UpdateCustomer(int custID, string fName, string lName, string phone, string email, int Zip);

        bool UpdateCustomer(Customer customer);

        Customer GetCustomerByID(int custID);

    }
}
