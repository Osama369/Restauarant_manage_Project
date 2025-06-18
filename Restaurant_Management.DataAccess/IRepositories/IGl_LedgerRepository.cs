using Restauarant_Management.Models.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Restaurant_Management.DataAccess.IRepositories
{
    internal interface IGl_LedgerRepository
    {
        Task<Gl_Ledger> AddAsync(Gl_Ledger gl_Ledger);  // will get user as parameters 
        Task<Gl_Ledger> Update(Gl_Ledger gl_Ledger);
        Task<Gl_Ledger> GetByIdAsync(int id);

        Task Remove(Gl_Ledger gl_Ledger);

        Task<List<Gl_Ledger>> GetAllAsync();
    }
}
