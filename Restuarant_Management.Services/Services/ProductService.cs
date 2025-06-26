using Restauarant_Management.Models.Models;
using Restaurant_Management.DataAccess.IRepositories;
using Restuarant_Management.Services.IServices;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Restuarant_Management.Services.Services
{
    public class ProductService : IProductService 
    {
        private readonly IProductRepository _productRepository;

        public ProductService(IProductRepository productRepository)
        { 
           _productRepository = productRepository;
        }

        public async Task AddProductAsync(Product pro)
        {
            await _productRepository.AddAsync(pro);

        }

        public async Task DeleteProductAsync(int id)
        {
           await _productRepository.Remove(id);
        }

        public async Task<List<Product>> GetAllProductAsync()
        {
           return await _productRepository.GetAllAsync();
        }

        public async Task<Product> GetProductByIdAsync(int id)
        {
           return  await _productRepository.GetByIdAsync(id);
        }

        public async Task<Product> UpdateProductAsync(Product pro)
        {
            return await _productRepository.Update(pro);
        }
    }
}
