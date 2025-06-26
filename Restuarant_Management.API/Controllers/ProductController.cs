using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Restauarant_Management.Models.Models;
using Restuarant_Management.Services.IServices;

namespace Restuarant_Management.API.Controllers
{
    [Route("api/[controller]/[action]")]  // Product/GetAllProduct

    [ApiController]
    public class ProductController : ControllerBase
    {
        private readonly IProductService productService;

        public ProductController(IProductService productService)
        {
            this.productService = productService;
        }


        [HttpGet]

        public async Task<IActionResult> GetAllProducts()

        { 
          var products=   await productService.GetAllProductAsync();
            return Ok(products);
        }

        [HttpPost] 
        public async Task<IActionResult> Add(Product product)
        {
            await productService.AddProductAsync(product);
            return Ok(new { message = "Product added successfully." });
        }


        [HttpGet("{id}")]
        public async Task<IActionResult> Get(int id)
        {
            var product = await productService.GetProductByIdAsync(id);
            return product != null ? Ok(product) : NotFound("Product not found.");
        }


        [HttpPut]
        public async Task<IActionResult> Update(Product product)
        {
            var updated = await productService.UpdateProductAsync(product);
            return Ok(updated);
        }


        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(int id)
        {
            await productService.DeleteProductAsync(id);
            return Ok(new { message = "Product deleted successfully." });
        }
    }
}
