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
    public class CustomerRepository : ICustomerRepository
    {

        private readonly MyDbContext _dbcontext;

        public CustomerRepository(MyDbContext dbcontext)
        {
            _dbcontext = dbcontext;
        }

        public async Task<Customer> AddAsync(Customer customer)
        {
            await _dbcontext.Customer.AddAsync(customer);
            await _dbcontext.SaveChangesAsync();
            return customer;
        }

        public async Task<List<Customer>> GetAllAsync()
        {
            return _dbcontext.Customer.ToList();
        }

        public async Task<Customer> GetByIdAsync(int id)
        {
            try
            {
                var res = await _dbcontext.Customer.FindAsync(id);
                return res;
            }
            catch (Exception ex)

            {
                return new Customer();
            }
        }

        public async Task Remove(int id)
        {
            var customers = await _dbcontext.Customer.FindAsync(id);
            if (customers != null)
            { 
             _dbcontext.Customer.Remove(customers);
                await _dbcontext.SaveChangesAsync();
            }

        }

        public async Task<Customer> Update(Customer customer)
        {
            _dbcontext.Customer.Update(customer);
            await _dbcontext.SaveChangesAsync();
            return customer;
        }
    }
}
