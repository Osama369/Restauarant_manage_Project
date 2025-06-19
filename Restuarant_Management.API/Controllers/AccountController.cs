using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Restauarant_Management.Models.Models;
using Restuarant_Management.Services.IServices;

namespace Restuarant_Management.API.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class AccountController : Controller
    {

        private readonly SignInManager<IdentityUser> _signInManager;
        private readonly UserManager<IdentityUser> _userManager;

        private readonly IUserService _userService;


        public AccountController(SignInManager<IdentityUser> _signInManager , UserManager<IdentityUser> _userManager , IUserService _userService)
        { 
          this._signInManager = _signInManager;
           this._userManager = _userManager;
            this._userService = _userService;
        }
        [HttpPost]
        public async Task<IActionResult> Registered(RegisterViewModel user)
        {
            await _userService.AddUserAsync(user);
            return Ok(user);
        }
        [HttpPost]
        public async Task<IActionResult> LogIn(LoginViewModel model)
        {
            

            // Find user by email
            var user = await _userManager.FindByEmailAsync(model.Email);
            if (user == null)
                return Unauthorized("Invalid email or password.");

            // Manually verify password
            var isPasswordValid = await _userManager.CheckPasswordAsync(user, model.Password);
            if (!isPasswordValid)
                return Unauthorized("Invalid email or password.");

            // Sign in the user manually
            await _signInManager.SignInAsync(user, isPersistent: (bool)model.RememberMe);

            return Ok("Login successful.");
        }


    }
}
