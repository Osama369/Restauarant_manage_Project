using Restauarant_Management.Models.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Restuarant_Management.Services.IServices
{
    public interface IGl_LedgerService 
    {
        Task AddLedgerAsync(Gl_Ledger gl_Ledger);

        Task<Gl_Ledger> UpdateLedgerAsync(Gl_Ledger gl_Ledger);

        Task DeleteLedgerAsync(int id);

        Task<Gl_Ledger> GetLedgerByIdAsync(int id);

        Task<List<Gl_Ledger>> GetAllLedgerAsync();
    }
}
