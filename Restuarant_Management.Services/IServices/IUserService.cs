using Restauarant_Management.Models.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Restuarant_Management.Services.IServices
{
    public interface IUserService
    {

        Task AddUserAsync(RegisterViewModel registerUser);

        Task<User> UpdateUserAsync(User user);

        Task DeleteUserAsync(User user);

        Task<User> GetUserByIdAsync(int id);

        Task<List<User>> GetAllUserAsync();

        Task<User> GetByEmailAsync(string email);

    }
}
