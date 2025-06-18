using Restauarant_Management.Models.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Restaurant_Management.DataAccess.IRepositories
{
    internal interface ISupplierRepository
    {
        Task<Supplier> AddAsync(Supplier supplier);  // will get user as parameters 
        Task<Supplier> Update(Supplier supplier);
        Task<Supplier> GetByIdAsync(int id);

        Task Remove(Supplier supplier);

        Task<List<Supplier>> GetAllAsync();
    }
}
