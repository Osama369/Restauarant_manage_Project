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
    public class CustomerService : ICustomerService
    {

        private readonly ICustomerRepository _customerRepository;

        public CustomerService(ICustomerRepository customerRepository)
        {
            _customerRepository = customerRepository;
        }

        public async Task AddCustomerAsync(Customer customer)
        {
            await _customerRepository.AddAsync(customer);
        }

        public async Task DeleteCustomerAsync(int id)
        {
           await _customerRepository.Remove(id);
        }

        public async Task<List<Customer>> GetAllCustomerAsync()
        {
           return await _customerRepository.GetAllAsync();
        }

        public async Task<Customer> GetCustomerByIdAsync(int id)
        {
            return await _customerRepository.GetByIdAsync(id);
        }

        public async Task<Customer> UpdateCustomerAsync(Customer customer)
        {
           return await _customerRepository.Update(customer);
        }
    }
}
