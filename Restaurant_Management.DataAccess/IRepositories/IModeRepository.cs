using Restauarant_Management.Models.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Restaurant_Management.DataAccess.IRepositories
{
    public interface IModeRepository
    {
        Task<Mode> AddAsync(Mode mode);  
        Task<Mode > Update(Mode  mode);
        Task<Mode> GetByIdAsync(int id);

        Task Remove(Mode mode);

        Task<List<Mode>> GetAllAsync();
    }
}
