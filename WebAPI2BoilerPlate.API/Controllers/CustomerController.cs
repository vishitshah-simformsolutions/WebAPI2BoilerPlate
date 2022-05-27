using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using WebAPI2BoilerPlate.IBusiness;
using WebAPI2BoilerPlate.Model;

namespace WebAPI2BoilerPlate.Controllers
{
    public class CustomerController : ApiController
    {
        private readonly ICustomerService _customerService;
        public CustomerController(ICustomerService customerService)
        {
            _customerService = customerService;
        }

        // GET api/values
        [HttpGet]
        public IHttpActionResult GetCustomers()
        {
            return Ok(_customerService.GetCustomers());
        }

        // GET api/values/5
        [HttpGet]
        public IHttpActionResult GetCustomerById(int id)
        {
            return Ok(_customerService.GetCustomerById(id));
        }

        // POST api/values
        [HttpPost]
        public IHttpActionResult Post([FromBody] Customer customer)
        {
            _customerService.SaveCustomer(customer);
            return Ok();
        }

        // DELETE api/values/5
        [HttpDelete]
        public IHttpActionResult Delete(int id)
        {
            _customerService.DeleteCustomerById(id);
            return Ok();
        }
    }
}
