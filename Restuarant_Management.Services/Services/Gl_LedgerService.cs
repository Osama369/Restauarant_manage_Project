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
    public class Gl_LedgerService : IGl_LedgerService
    {

        private readonly IGl_LedgerRepository gl_LedgerRepository;

        public Gl_LedgerService(IGl_LedgerRepository gl_LedgerRepository)
        {
            this.gl_LedgerRepository = gl_LedgerRepository;
        }


        public async Task AddLedgerAsync(Gl_Ledger gl_Ledger)
        {
           await gl_LedgerRepository.AddAsync(gl_Ledger);
        }

        public async Task DeleteLedgerAsync(int id)
        {
           await gl_LedgerRepository.Remove(id);
        }

        public async Task<List<Gl_Ledger>> GetAllLedgerAsync()
        {
           return await gl_LedgerRepository.GetAllAsync();
        }

        public async Task<Gl_Ledger> GetLedgerByIdAsync(int id)
        {
            return await gl_LedgerRepository.GetByIdAsync(id);
        }

        public async Task<Gl_Ledger> UpdateLedgerAsync(Gl_Ledger gl_Ledger)
        {
            return await gl_LedgerRepository.Update(gl_Ledger);
        }
    }
}
