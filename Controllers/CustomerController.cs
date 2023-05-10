using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using WebAPI.Interfaces;
using WebAPI.Models;

namespace WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CustomerController : ControllerBase
    {
        private readonly IHome _home;
        public CustomerController(IHome home)
        {
            _home = home;
        }

        [HttpPost("addCustomer")]
        public Customer AddCustomer(Customer customer)
        {
            try
            {
                _home.AddCustomer(customer);
            }
            catch (Exception ex)
            {
                customer= new Customer();
            }
            return customer;
        }
    }
}
