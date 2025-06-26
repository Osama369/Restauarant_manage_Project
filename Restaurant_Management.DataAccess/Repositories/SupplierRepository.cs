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
     public  class SupplierRepository : ISupplierRepository
    {
        private readonly MyDbContext _dbcontext;

        public SupplierRepository(MyDbContext dbcontext)
        {
            _dbcontext = dbcontext;

        }

        public async Task<Supplier> AddAsync(Supplier supplier)
        {
           await _dbcontext.Supplier.AddAsync(supplier);
            await _dbcontext.SaveChangesAsync();

            return supplier; 
        }

        public async Task<List<Supplier>> GetAllAsync()
        {
            return _dbcontext.Supplier.ToList();
        }

        public async Task<Supplier> GetByIdAsync(int id)
        {
            try
            {
                var res = await _dbcontext.Supplier.FindAsync(id);
                return res;
            }
            catch (Exception ex)

            {
                return new Supplier();
            }
        }

        public async Task Remove(int id)
        {
            var supplier = await _dbcontext.Supplier.FindAsync(id);
            if (supplier != null)
            {
                _dbcontext.Supplier.Remove(supplier);
                await _dbcontext.SaveChangesAsync();    
            }
        }

        public async Task<Supplier> Update(Supplier supplier)
        {
            _dbcontext.Supplier.Update(supplier);
            await _dbcontext.SaveChangesAsync();
            return supplier;
        }
    }
}
