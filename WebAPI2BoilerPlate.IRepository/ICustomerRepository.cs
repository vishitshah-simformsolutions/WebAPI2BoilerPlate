﻿using System.Collections.Generic;
using WebAPI2BoilerPlate.Model;

namespace WebAPI2BoilerPlate.IRepository
{
    public interface ICustomerRepository
    {
        void GetCustomerById(int id);

        void DeleteCustomerById(int id);

        List<Customer> GetCustomers();

        void SaveCustomer(Customer customer);
    }
}
