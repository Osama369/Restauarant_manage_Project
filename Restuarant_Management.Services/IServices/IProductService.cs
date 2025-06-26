using Restauarant_Management.Models.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Restuarant_Management.Services.IServices
{
    public interface IProductService
    {

        Task AddProductAsync(Product pro);

        Task<Product> UpdateProductAsync(Product pro);

        Task DeleteProductAsync(int id);

        Task<Product> GetProductByIdAsync(int id);

        Task<List<Product>> GetAllProductAsync();

        //Task<Product> GetByEmailAsync(string email);
    }
}
