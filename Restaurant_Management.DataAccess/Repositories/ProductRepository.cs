using Restauarant_Management.Models.Models;
using Restaurant_Management.DataAccess.DbSet;
using Restaurant_Management.DataAccess.IRepositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Restaurant_Management.DataAccess.Repositories
{
    public class ProductRepository : IProductRepository
    {

        private readonly MyDbContext _dbcontext;

        public ProductRepository(MyDbContext dbContext) 
        { 
            _dbcontext = dbContext;
        }

        public async Task<Product> AddAsync(Product prod)
        {
            await _dbcontext.Product.AddAsync(prod);
            await _dbcontext.SaveChangesAsync();
            return prod; 
        }

        public async Task<List<Product>> GetAllAsync()
        {
           return  _dbcontext.Product.ToList();
        }

        public async Task<Product> GetByIdAsync(int id)
        {
            try
            {
                var res = await _dbcontext.Product.FindAsync(id);
                return res;

            }
            catch (Exception ex)
            { 
               
            }  return new Product();
        }

        public async Task Remove(int id)
        {
            var product = await _dbcontext.Product.FindAsync(id);
            if (product != null)
            {
                _dbcontext.Product.Remove(product); // ✅ Corrected
                await _dbcontext.SaveChangesAsync();
            }
        }


        public async Task<Product> Update(Product prod)
        {
            _dbcontext.Product.Update(prod);
            await _dbcontext.SaveChangesAsync();
            return prod;
        }
    }
}
