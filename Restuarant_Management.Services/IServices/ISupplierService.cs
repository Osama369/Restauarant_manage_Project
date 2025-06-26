using Restauarant_Management.Models.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Restuarant_Management.Services.IServices
{
    public interface ISupplierService
    {

        Task AddSupplierAsync(Supplier supplier);

        Task<Supplier> UpdateSupplierAsync(Supplier supplier);

        Task DeleteSupplierAsync(int id);

        Task<Supplier> GetSupplierByIdAsync(int id);

        Task<List<Supplier>> GetAllSupplierAsync();
    }
}
