using Restauarant_Management.Models.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Restuarant_Management.Services.IServices
{
    public interface ICustomerService
    {
        Task AddCustomerAsync(Customer customer);

        Task<Customer> UpdateCustomerAsync(Customer customer);

        Task DeleteCustomerAsync(int id);

        Task<Customer> GetCustomerByIdAsync(int id);

        Task<List<Customer>> GetAllCustomerAsync();
    }
}
