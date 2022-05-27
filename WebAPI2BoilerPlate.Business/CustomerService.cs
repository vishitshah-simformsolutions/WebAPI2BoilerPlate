﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebAPI2BoilerPlate.IBusiness;
using WebAPI2BoilerPlate.IRepository;
using WebAPI2BoilerPlate.Model;

namespace WebAPI2BoilerPlate.Business
{
    public class CustomerService : ICustomerService
    {
        private readonly ICustomerRepository _customerRepository;

        public CustomerService(ICustomerRepository customerRepository)
        {
            _customerRepository = customerRepository;
        }
        public void GetCustomerById(int id)
        {

        }

        public void DeleteCustomerById(int id)
        {

        }

        public List<Customer> GetCustomers()
        {
            return _customerRepository.GetCustomers();
        }

        public void SaveCustomer(Customer customer)
        {

        }
    }
}
