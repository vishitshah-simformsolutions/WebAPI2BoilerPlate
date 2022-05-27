using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebAPI2BoilerPlate.IRepository;
using WebAPI2BoilerPlate.Model;

namespace WebAPI2BoilerPlate.Repository
{
    public class CustomerRepository : ICustomerRepository
    {
        public void GetCustomerById(int id)
        {

        }

        public void DeleteCustomerById(int id)
        {

        }

        public List<Customer> GetCustomers()
        {
            return new List<Customer>();
        }

        public void SaveCustomer(Customer customer)
        {

        }
    }
}
