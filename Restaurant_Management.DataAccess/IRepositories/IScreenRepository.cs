using Restauarant_Management.Models.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Restaurant_Management.DataAccess.IRepositories
{
    internal interface IScreenRepository
    {
        Task<Screen> AddAsync(Screen screen);  // will get user as parameters 
        Task<Screen> Update(Screen screen);
        Task<Screen> GetByIdAsync(int id);

        Task Remove(Screen screen);

        Task<List<Screen>> GetAllAsync();
    }
}
