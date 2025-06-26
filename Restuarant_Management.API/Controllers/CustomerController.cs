using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Restauarant_Management.Models.Models;
using Restuarant_Management.Services.IServices;

namespace Restuarant_Management.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CustomerController : ControllerBase
    {

        private readonly ICustomerService _customerService;

        public CustomerController(ICustomerService customerService)
        {
            _customerService = customerService;
        }

        [HttpGet]
        public async Task<IActionResult> GetAllCustomer()

        {
            var customers = await _customerService.GetAllCustomerAsync();
            return Ok(customers);
        }

        [HttpPost]

        public async Task<IActionResult> Add(Customer customer)

        {
            await _customerService.AddCustomerAsync(customer);
            return Ok(new { message = "Customer add successfully" });

        }


        [HttpGet("{id}")]

        public async Task<IActionResult> Get(int id)
        {
            var customer = await _customerService.GetCustomerByIdAsync(id);
            return customer != null ? Ok(customer) : NotFound("Product not found.");

        }

        [HttpPut]
        public async Task<IActionResult> Update(Customer customer)

        {
            var updated = await _customerService.UpdateCustomerAsync(customer);
            return Ok(updated);

        }

        [HttpDelete("{id}")]

        public async Task<IActionResult> Delete(int id)

        {

            await _customerService.DeleteCustomerAsync(id);
            return Ok(new { message = "Customer deleted successfully" });
        }

    }
}
