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

        public async Task<User> UpdateUserAsync(User user)
        {
            return await _userRepository.Update(user);
        }


        public async Task DeleteUserAsync(User user)
        {
            await _userRepository.Remove(user); 
        }

        public async Task<List<User>> GetAllUserAsync()
        {
           return   await  _userRepository.GetAllAsync();
        }

        public async Task<User> GetUserByIdAsync(int id)
        {
            return await _userRepository.GetByIdAsync(id);
        }

        public async Task<User?> GetByEmailAsync(string email)
        {
          return await _userRepository.GetByEmailAsync(email);
        }
    }
}
