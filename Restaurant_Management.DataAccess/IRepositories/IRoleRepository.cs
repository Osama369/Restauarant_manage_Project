using Restauarant_Management.Models.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Restaurant_Management.DataAccess.IRepositories
{
    public interface IRoleRepository
    {
        Task<Role> AddAsync(Role role);  // will get user as parameters 
        Task<Role> Update(Role role );
        Task<Role> GetByIdAsync(int id);

        Task Remove(Role role );

        Task<List<Role>> GetAllAsync();
    }
}
