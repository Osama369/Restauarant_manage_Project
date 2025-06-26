using Restauarant_Management.Models.Models;
using Restaurant_Management.DataAccess.DbSet;
using Restaurant_Management.DataAccess.IRepositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Restaurant_Management.DataAccess.Repositories
{
    public class Gl_LedgerRepository : IGl_LedgerRepository
    {

        private readonly MyDbContext _dbcontext;

        public Gl_LedgerRepository(MyDbContext dbcontext)
        {
            _dbcontext = dbcontext;
        }

        public async Task<Gl_Ledger> AddAsync(Gl_Ledger gl_Ledger)
        {
            await _dbcontext.Gl_Ledger.AddAsync(gl_Ledger);
            await _dbcontext.SaveChangesAsync();
            return gl_Ledger;
        }

        public async Task<List<Gl_Ledger>> GetAllAsync()
        {
          return  _dbcontext.Gl_Ledger.ToList();
        }

        public async Task<Gl_Ledger> GetByIdAsync(int id)
        {
            try

            {
              var res=  await _dbcontext.Gl_Ledger.FindAsync();
                return res;
            } catch (Exception ex)

            {
                return new Gl_Ledger();
            }
        }

        public async Task Remove(int id)
        {
         var ledger =  await _dbcontext.Gl_Ledger.FindAsync(id);
            if (ledger != null)
                _dbcontext.Gl_Ledger.Remove(ledger);
                  await _dbcontext.SaveChangesAsync();
        }

        public async Task<Gl_Ledger> Update(Gl_Ledger gl_Ledger)
        {
            _dbcontext.Gl_Ledger.Update(gl_Ledger);
            await _dbcontext.SaveChangesAsync();
            return gl_Ledger;
        }
    }
}
