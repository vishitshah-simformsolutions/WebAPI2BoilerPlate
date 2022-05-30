using System.Collections.Generic;
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
    }
}
