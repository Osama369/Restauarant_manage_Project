using Restauarant_Management.Models.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Restaurant_Management.DataAccess.IRepositories
{
    public interface IUserRepository
    {
        Task<User> AddAsync(User user);  // will get user as parameters 
        Task<User> Update(User user);
        Task<User> GetByIdAsync(int id);

        Task Remove(User user);

        Task<List<User?>> GetAllAsync();
    }
}
