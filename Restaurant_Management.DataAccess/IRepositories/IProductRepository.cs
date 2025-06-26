using Restauarant_Management.Models.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Restaurant_Management.DataAccess.IRepositories
{
     public  interface IProductRepository
    {
        Task<Product> AddAsync(Product prod);  // will get prod as parameters 
        Task<Product> Update(Product prod);
        Task<Product> GetByIdAsync(int id);

        Task Remove(int id);   // delete based on id 

        Task<List<Product>> GetAllAsync();
    };
}
