using Microsoft.EntityFrameworkCore;
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
      public class UserRepository : IUserRepository
    {
        private readonly MyDbContext _dbcontext;

        public UserRepository(MyDbContext _dbcontext)
        {
            this._dbcontext = _dbcontext;
        }

        public async Task<User> AddAsync(User user) 
        {
            await _dbcontext.Users.AddAsync(user);  // add 
            await _dbcontext.SaveChangesAsync();  // saveChange 
            return user; // return 
        
        }

        public async Task<User> GetByIdAsync(int id) {

            try
            {
                var res = await _dbcontext.Users.FindAsync(id);
                return res;

            } catch (Exception e) { 
                
            }
           return new User();

        }

        public async Task<List<User>> GetAllAsync() 
        {
            return _dbcontext.Users.ToList();
        }

        public async Task<User> Update(User user) 
        
        { 
          _dbcontext.Users.Update(user);
            await _dbcontext.SaveChangesAsync();
            return user;
        }


        public async Task Remove(User user)

        { 
            _dbcontext.Users.Remove(user);
            await _dbcontext.SaveChangesAsync();
        }
         
        public async Task<User> GetByEmailAsync(string email)
        {
            return await _dbcontext.Users.FirstOrDefaultAsync(u => u.userEmail == email);

        }
    }
}
