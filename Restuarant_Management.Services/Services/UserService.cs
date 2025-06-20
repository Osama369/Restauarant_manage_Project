using Microsoft.AspNetCore.Identity;
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
    public class UserService : IUserService
    {

        private readonly IUserRepository _userRepository;
        private readonly UserManager<IdentityUser> _userManager;
       


        public UserService(IUserRepository userRepository, UserManager<IdentityUser> _userManager) 
        { 
          _userRepository = userRepository;
            this._userManager = _userManager;
        }
        public async  Task AddUserAsync(RegisterViewModel registerUser)
        {
            User user = new User();  
            user.userEmail = registerUser.Email;
            user.name = registerUser.UserName;
            user.password = registerUser.Password;
            user.phone = registerUser.Phone;
            user.roleId = registerUser.roleId;

           
           
            IdentityUser identityUser = new IdentityUser
            {
                Email = user.userEmail,
                UserName = user.name
            };

             // creatAsyn take identityUser and password 

            var result =await _userManager.CreateAsync(identityUser,user.password);
            if (result.Succeeded)
            {
                user.identityUserId = identityUser.Id;
                await _userRepository.AddAsync(user);
            }
        }

        public Task<User> UpdateUserAsync(User user)
        {
            throw new NotImplementedException();
        }


        public Task DeleteUserAsync(User user)
        {
            throw new NotImplementedException();
        }

        public Task<List<User>> GetAllUserAsync()
        {
            throw new NotImplementedException();
        }

        public Task<User> GetUserByIdAsync(int id)
        {
            throw new NotImplementedException();
        }

        public async Task<User?> GetByEmailAsync(string email)
        {
          return await _userRepository.GetByEmailAsync(email);
        }
    }
}
