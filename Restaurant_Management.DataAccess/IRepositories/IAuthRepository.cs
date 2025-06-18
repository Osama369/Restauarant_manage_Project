using Restauarant_Management.Models.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Restaurant_Management.DataAccess.IRepositories
{
    internal interface IAuthRepository
    {
        Task<Auth> AddAsync(Auth auth);  // will get user as parameters 
        Task<Auth> Update(Auth auth);
        Task<Auth> GetByIdAsync(int id);

        Task Remove(Auth auth);

        Task<List<Auth>> GetAllAsync();
    }
}
