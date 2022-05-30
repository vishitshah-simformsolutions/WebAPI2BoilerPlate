using System.Collections.Generic;
using System.Linq;
using WebAPI2BoilerPlate.Data;
using WebAPI2BoilerPlate.IRepository;
using Customer = WebAPI2BoilerPlate.Model.Customer;

namespace WebAPI2BoilerPlate.Repository
{
    public class CustomerRepository : ICustomerRepository
    {
        public Customer GetCustomerById(int id)
        {
            using (Interview_TestEntities _dbContext = new Interview_TestEntities())
            {
                return _dbContext.Customer.Where(x => x.Id == id)
                    .Select(customer => new Customer
                    {
                        Id = customer.Id,
                        CustomerEmail = customer.CustomerEmail,
                        CustomerName = customer.CustomerName
                    })
                    .FirstOrDefault();
            }
        }

        public void DeleteCustomerById(int id)
        {
            using (Interview_TestEntities _dbContext = new Interview_TestEntities())
            {
                var customer = _dbContext.Customer.First(x => x.Id == id);
                _dbContext.Customer.Remove(customer);
                _dbContext.SaveChanges();
            }
        }

        public List<Customer> GetCustomers()
        {
            using (Interview_TestEntities _dbContext = new Interview_TestEntities())
            {
                return _dbContext.Customer.Select(customer => new Customer
                {
                    Id = customer.Id,
                    CustomerEmail = customer.CustomerEmail,
                    CustomerName = customer.CustomerName
                }).ToList();
            }
        }

        public void SaveCustomer(Customer customer)
        {
            using (Interview_TestEntities _dbContext = new Interview_TestEntities())
            {
                if (customer.Id > 0)
                {
                    var _customer = GetCustomerById(customer.Id);
                    if (_customer != null)
                    {
                        _customer.CustomerEmail = customer.CustomerEmail;
                        _customer.CustomerName = customer.CustomerName;
                    }
                }
                else
                {
                    _dbContext.Customer.Add(new Data.Customer
                    {
                        Id = customer.Id,
                        CustomerName = customer.CustomerName,
                        CustomerEmail = customer.CustomerEmail
                    });
                }
                _dbContext.SaveChanges();
            }
        }
    }
}
