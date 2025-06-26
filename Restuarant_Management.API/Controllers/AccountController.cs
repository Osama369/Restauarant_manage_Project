using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.IdentityModel.Tokens;
using Restauarant_Management.Models.Models;
using Restuarant_Management.Services.IServices;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;

namespace Restuarant_Management.API.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class AccountController : Controller
    {

        private readonly SignInManager<IdentityUser> _signInManager;
        private readonly UserManager<IdentityUser> _userManager;

        private readonly IUserService _userService;
        private readonly IConfiguration _configuration;


        public AccountController(SignInManager<IdentityUser> _signInManager , IConfiguration configuration,  UserManager<IdentityUser> _userManager , IUserService _userService)
        { 
          this._signInManager = _signInManager;
           this._userManager = _userManager;
            this._userService = _userService;

            _configuration = configuration;

        }
        [HttpPost]
        public async Task<IActionResult> Registered(RegisterViewModel user)
        {
           await _userService.AddUserAsync(user);
            return Ok();
        }
        [HttpPost]
        public async Task<IActionResult> LogIn(LoginViewModel model)
        {
            // Step 1: Find user by email
            var user = await _userManager.FindByEmailAsync(model.Email);
            if (user == null)
                return Unauthorized("Invalid email or password.");

            // Step 2: Verify password
            var isPasswordValid = await _userManager.CheckPasswordAsync(user, model.Password);
            if (!isPasswordValid)
                return Unauthorized("Invalid email or password.");

            //var roles = await _userManager.GetRolesAsync(user);
            //var roleName = roles.FirstOrDefault() ?? "Staff";
            //var roleId = roleName == "Admin" ? "1" : "2";

            // Step 3: Get user role
            var userbyEmail = await _userService.GetByEmailAsync(user.Email);
            var roleId = userbyEmail.roleId ?? 2; // default to Staff
            string roleName = roleId == 1 ? "Admin" : "Staff";






            // Step 4: Create claims
      var authClaims = new List<Claim>
    {
        new Claim("UserId", user.Id),
        new Claim("RoleID", roleId.ToString()),  // 1 or 2
        new Claim(ClaimTypes.Email, user.Email),  // email 
        new Claim(ClaimTypes.Role, roleName),  // roleName Admin or Staff
        new Claim(JwtRegisteredClaimNames.Jti, Guid.NewGuid().ToString())
    };

            // Step 5: Read settings from configuration
            var jwtKey = _configuration["Jwt:Key"];
            var jwtIssuer = _configuration["Jwt:Issuer"];
            var jwtAudience = _configuration["Jwt:Audience"];
            var jwtDuration = Convert.ToDouble(_configuration["Jwt:DurationInMinutes"]);

            var authSigningKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(jwtKey));

            // Step 6: Generate token
            var token = new JwtSecurityToken(
                issuer: jwtIssuer,
                audience: jwtAudience,
                expires: DateTime.UtcNow.AddMinutes(jwtDuration),
                claims: authClaims,
                signingCredentials: new SigningCredentials(authSigningKey, SecurityAlgorithms.HmacSha256)
            );

            var tokenString = new JwtSecurityTokenHandler().WriteToken(token);

            // Step 7: Return token
            return Ok(new
            {
                token = tokenString,
                expiration = token.ValidTo,
                email = user.Email,
                role = roleName
            });
        }



    }
}
