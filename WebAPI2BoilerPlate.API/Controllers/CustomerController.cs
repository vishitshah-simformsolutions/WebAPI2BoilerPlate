using System.Web.Http;
using WebAPI2BoilerPlate.IBusiness;
using WebAPI2BoilerPlate.Model;

namespace WebAPI2BoilerPlate.Controllers
{
    [Authorize]
    public class CustomerController : ApiController
    {
        private readonly ICustomerService _customerService;

        public CustomerController(ICustomerService customerService)
        {
            _customerService = customerService;
        }

        /// <summary>
        /// Get All Customer
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        public IHttpActionResult GetCustomers()
        {
            return Ok(_customerService.GetCustomers());
        }

        /// <summary>
        /// Get Customer By Id
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        [HttpGet]
        public IHttpActionResult GetCustomerById(int id)
        {
            return Ok(_customerService.GetCustomerById(id));
        }

        /// <summary>
        /// Save Customer
        /// </summary>
        /// <param name="customer"></param>
        /// <returns></returns>
        [HttpPost]
        public IHttpActionResult Post([FromBody] Customer customer)
        {
            _customerService.SaveCustomer(customer);
            return Ok();
        }

        /// <summary>
        /// Delete Customer By Id
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        [HttpDelete]
        public IHttpActionResult Delete(int id)
        {
            _customerService.DeleteCustomerById(id);
            return Ok();
        }
    }
}
