using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Restauarant_Management.Models.Models;
using Restuarant_Management.Services.IServices;

namespace Restuarant_Management.API.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class SupplierController : ControllerBase
    {
        private readonly ISupplierService _supplierService;

        public SupplierController(ISupplierService supplierService)
        {
            _supplierService = supplierService;
        }

         [HttpGet]

         public async Task<IActionResult> GetAllSupplier()

        {
            var supplier = await _supplierService.GetAllSupplierAsync();
            return Ok(supplier);

        }

        [HttpPost]
        public async Task<IActionResult> Add(Supplier supplier)

        { 
           await _supplierService.AddSupplierAsync(supplier);
            return Ok(new { message = "supplier added successfully" });
        }

        [HttpGet("{id}")]

        public async Task<IActionResult> Get(int id)

        { 
          var suppl = await _supplierService.GetSupplierByIdAsync(id);

            return suppl != null  ? Ok(suppl) : NotFound("Supplier not found");
        }


        [HttpPut]
        public async Task<IActionResult> Update(Supplier supplier)

        {
            var updated = await _supplierService.UpdateSupplierAsync(supplier);
            return Ok(updated);

        }


        [HttpDelete("{id}")]

        public async Task<IActionResult> Delete(int id)

        {

            await _supplierService.DeleteSupplierAsync(id);
            return Ok(new { message = "Supplier deleted successfully" });
        }
    }
}
