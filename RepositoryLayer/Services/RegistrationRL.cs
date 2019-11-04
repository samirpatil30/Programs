using CommanLayer.Model;
using Microsoft.AspNetCore.Identity;
using Microsoft.Extensions.Configuration;
using Microsoft.IdentityModel.JsonWebTokens;
using Microsoft.IdentityModel.Tokens;
using RepositoryLayer.Interface;
using System;
using System.Collections.Generic;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;
using JwtRegisteredClaimNames = Microsoft.IdentityModel.JsonWebTokens.JwtRegisteredClaimNames;

namespace RepositoryLayer.Services
{
    /// <summary>
    /// RegistrationRL
    /// </summary>
    public class RegistrationRL : IRegistraionRl
    {
        /// <summary>
        /// User Manager
        /// </summary>
        private UserManager<ApplicationUser> _userManager;

        private IConfiguration _configuration;

        /// <summary>
        /// Create the parameterized Constructor of class and pass the UserManager
        /// </summary>
        /// <param name="userManager"></param>
        public RegistrationRL(UserManager<ApplicationUser> userManager, IConfiguration configuration)
        {
            this._userManager = userManager;
            _configuration = configuration;
        }

        /// <summary>
        /// AddUser Details 
        /// </summary>
        /// <param name="user"></param>
        /// <returns></returns>
        public async Task<bool> AddUserDetails(UserDetails user)
        {
            //// Create the instance of ApplicationUser and stroe the details
            var applicationUser = new ApplicationUser()
            {
                FirstName = user.FirstName,
                LastName = user.LastName,
                UserName = user.UserName,
                Email = user.Email,

            };
            try
            {
                //// 
                var result = await _userManager.CreateAsync(applicationUser, user.Password);
                if (result != null)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            catch (Exception exception)
            {
                throw exception;
            }

        }

        public async Task<string> Login(LoginModel loginModel)
        {
            //// the variable user stores the username
            var user = await _userManager.FindByNameAsync(loginModel.UserName);
            if (user != null && await _userManager.CheckPasswordAsync(user, loginModel.Password))
            {
                var claim = new[]
                {
                        new Claim(JwtRegisteredClaimNames.Sub,user.UserName)
                };

                var securityKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(_configuration["Jwt:Key"]));
                var credentials = new SigningCredentials(securityKey, SecurityAlgorithms.HmacSha256);

                //// Here we Generate JWT roken and create the instance of JwtSecurityToken
                var token = new JwtSecurityToken(_configuration["Jwt:Issuer"],
                  _configuration["Jwt:Issuer"],
                  null,
                  expires: DateTime.Now.AddMinutes(120),
                  signingCredentials: credentials);

                return new JwtSecurityTokenHandler().WriteToken(token);
            }
            else
            {
                return "Invalid User";
            }


            //// securityKey stores the result of SymmetricSecurityKey i.e securityKey
           
        }
    }
}
