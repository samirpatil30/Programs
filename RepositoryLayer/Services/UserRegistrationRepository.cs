using CommanLayer.Model;
using CommanLayer.MSMQ;
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
    public class UserRegistrationRepository : IUserRegistraionRepositpry
    {
        /// <summary>
        /// User Manager
        /// </summary>
        private UserManager<ApplicationUser> _userManager;

        //private IConfiguration _configuration;

        /// <summary>
        /// Create the parameterized Constructor of class and pass the UserManager
        /// </summary>
        /// <param name="userManager"></param>
        public UserRegistrationRepository(UserManager<ApplicationUser> userManager)
        {
           _userManager = userManager;
            
        }

        /// <summary>
        /// AddUser Details 
        /// </summary>
        /// <param name="user"></param>
        /// <returns></returns>
        public async Task<bool> AddUserDetails(UserDetails user)
        {
            //// Create the instance of ApplicationUser and store the details
            var applicationUser = new ApplicationUser()
            {
                FirstName = user.FirstName,
                LastName = user.LastName,
                UserName = user.UserName,
                Email = user.Email,

            };
            try
            {         
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

        /// <summary>
        /// Logins the specified login model.
        /// </summary>
        /// <param name="loginModel">The login model.</param>
        /// <returns></returns>
        public async Task<string> Login(LoginModel loginModel)
        {
            //// it confirms that user is avaiable in database or not
            var user = await _userManager.FindByNameAsync(loginModel.UserName);

            //// check the username and password is matched in database or not
            if (user != null && await _userManager.CheckPasswordAsync(user, loginModel.Password))
            {
                string key = "EF4ABEAB56153D93D0E97048FC50215C0264CFF";

                ////Here generate encrypted key and result store in security key
                var securityKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(key));

                //// here using securitykey and algorithm(security) the creadintails is generate(SigningCredentials present in Token)
                var creadintials = new SigningCredentials(securityKey, SecurityAlgorithms.HmacSha256);
                var claims = new[] {
               new Claim("UserName",user.UserName),
                };

                var token = new JwtSecurityToken("Security token", "https://Test.com",
                    claims,
                    DateTime.UtcNow,
                    expires: DateTime.Now.AddDays(1),
                    signingCredentials: creadintials);

                return new JwtSecurityTokenHandler().WriteToken(token);
            }
            else
            {
               
                return "Invalid User";
            }
        }

        public async Task<string> ForgotPassword(ForgotPasswordModel passwordModel)
        {
           
            try
            {
                var user = await _userManager.FindByEmailAsync(passwordModel.Email);
                if (user != null)
                {
                    ////here we create object of MsmqTokenSender which is present in Common-Layer
                    MsmqTokenSender msmq = new MsmqTokenSender();

                    ////it creates the SecurityTokenDescriptor
                    var tokenDescripter = new SecurityTokenDescriptor
                    {
                        Subject = new ClaimsIdentity(new Claim[]
                        {
                        new Claim("Email", user.Email.ToString())
                        }),
                        Expires = DateTime.UtcNow.AddDays(1),

                    };

                    var tokenHandler = new JwtSecurityTokenHandler();

                    ////it creates the security token
                    var securityToken = tokenHandler.CreateToken(tokenDescripter);

                    ////it writes security token to the token variable.
                    var token = tokenHandler.WriteToken(securityToken);
                    msmq.SendMsmqToken(passwordModel.Email, token);

                    return token;
                }
                else
                {
                    return "Invalid user";
                }
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
        }
       
       // public async Task<string> ResetPassword(ResetPasswordModel resetPasswordModel)
       // {
            //// Here Decode JWT token

           // var userResult = await _userManager.GeneratePasswordResetTokenAsync()
       // }
    }
}
