using Restauarant_Management.Models.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Restaurant_Management.DataAccess.IRepositories
{
    public interface IGl_TypeRepository
    {
        Task<Gl_Type> AddAsync(Gl_Type gl_Type);  // will get user as parameters 
        Task<Gl_Type> Update(Gl_Type gl_Type);
        Task<Gl_Type> GetByIdAsync(int id);

        Task Remove(Gl_Type gl_Type);

        Task<List<Gl_Type>> GetAllAsync();
    }
}
