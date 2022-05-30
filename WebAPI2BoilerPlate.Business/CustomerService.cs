using System.Collections.Generic;
using System.Runtime.CompilerServices;
using WebAPI2BoilerPlate.IBusiness;
using WebAPI2BoilerPlate.IRepository;
using WebAPI2BoilerPlate.Model;

namespace WebAPI2BoilerPlate.Business
{
    public class CustomerService : ICustomerService
    {
        private readonly ICustomerRepository _customerRepository;

        public CustomerService()
        {

        }
        public CustomerService(ICustomerRepository customerRepository)
        {
            _customerRepository = customerRepository;
        }
        public Customer GetCustomerById(int id)
        {
            return _customerRepository.GetCustomerById(id);
        }

        public void DeleteCustomerById(int id)
        {
            _customerRepository.DeleteCustomerById(id);
        }

        public List<Customer> GetCustomers()
        {
            return _customerRepository.GetCustomers();
        }

        public void SaveCustomer(Customer customer)
        {
            _customerRepository.SaveCustomer(customer);
        }

        public User GetUser(string email, string password)
        {
            //Make actual db call
            if (email != "vishit@simformsolutions.com" && password != "simform@123")
            {
                return null;
            }

            var user = new User
            {
                UserId = 1,
                UserName = "Vishit Shah",
                Email = "vishit@simformsolutions.com",
                Password = string.Empty,
            };

            return user;
        }
    }
}
