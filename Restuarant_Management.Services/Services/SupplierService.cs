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
    public class SupplierService : ISupplierService 
    {

        private readonly ISupplierRepository _supplierRepository;

        public SupplierService(ISupplierRepository supplierRepository)
        {
            _supplierRepository = supplierRepository;
        }

        public async Task AddSupplierAsync(Supplier supplier)
        {
            await _supplierRepository.AddAsync(supplier);
        }

        public async Task DeleteSupplierAsync(int id)
        {
            await _supplierRepository.Remove(id);
        }

        public async Task<List<Supplier>> GetAllSupplierAsync()
        {
          return  await _supplierRepository.GetAllAsync();
        }

        public async Task<Supplier> GetSupplierByIdAsync(int id)
        {
            return await _supplierRepository.GetByIdAsync(id);
        }

        public async Task<Supplier> UpdateSupplierAsync(Supplier supplier)
        {
            return await _supplierRepository.Update(supplier);
        }
    }
}
