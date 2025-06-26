using Restauarant_Management.Models.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Restaurant_Management.DataAccess.IRepositories
{
    public interface ICustomerRepository
    {
        Task<Customer> AddAsync(Customer customer);  // will get user as parameters 
        Task<Customer> Update(Customer customer);
        Task<Customer> GetByIdAsync(int id);

        Task Remove(int id);

        Task<List<Customer>> GetAllAsync();

    }
}
