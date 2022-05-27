using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebAPI2BoilerPlate.Model;

namespace WebAPI2BoilerPlate.IBusiness
{
    public interface ICustomerService
    {
        Customer GetCustomerById(int id);

        void DeleteCustomerById(int id);

        List<Customer> GetCustomers();

        void SaveCustomer(Customer customer);
    }
}
