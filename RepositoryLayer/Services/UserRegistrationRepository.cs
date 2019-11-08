﻿using CommanLayer.Model;
using CommanLayer.MSMQ;
using Microsoft.AspNetCore.Identity;
using Microsoft.Extensions.Configuration;
using Microsoft.IdentityModel.JsonWebTokens;
using Microsoft.IdentityModel.Tokens;
using RepositoryLayer.Interface;
using System;
using System.Collections.Generic;
using System.IdentityModel.Tokens.Jwt;
using System.Linq;
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
        public async Task<Tuple<bool, string>> AddUserDetails(UserDetails user)
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
                    return Tuple.Create(true, "User registration Successful");

                }
                else
                {
                    return Tuple.Create(false, "User registration is not Successful");
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
        public async Task<Tuple<string, string>> Login(LoginModel loginModel)
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

                var NewToken = new JwtSecurityTokenHandler().WriteToken(token);
                return Tuple.Create(NewToken, "User Login Successful");
            }
            else
            {
                return Tuple.Create("Token is not generated", "Invalid User");
            }
        }

        /// <summary>
        /// Forgots password.
        /// </summary>
        /// <param name="passwordModel">The password model.</param>
        /// <returns></returns>
        /// <exception cref="Exception"></exception>
        public async Task<string> ForgotPassword(ForgotPasswordModel passwordModel)
        {          
            try
            {
                //// variable user stores email of user
                var user = await _userManager.FindByEmailAsync(passwordModel.Email);

                //// If checks the Email is null or not
                if (user != null)
                {
                    ////here we create object of MsmqTokenSender which is present in Common-Layer
                    MsmqTokenSender msmq = new MsmqTokenSender();

                    ////it creates the SecurityTokenDescriptor
                    var tokenDescripter = new SecurityTokenDescriptor
                    {
                        Subject = new ClaimsIdentity(new Claim[]
                        {
                            //// Claims the identity
                            new Claim("Email", user.Email.ToString())
                        }),
                        Expires = DateTime.UtcNow.AddDays(1),

                    };

                    //// This object is used to decode JWTs
                         var tokenHandler = new JwtSecurityTokenHandler();

                    ////it creates the security token
                    var securityToken = tokenHandler.CreateToken(tokenDescripter);

                    ////it writes security token to the token variable.
                    var token = tokenHandler.WriteToken(securityToken);

                    //// Send the email and password to Method in MsmqTokenSender
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

        /// <summary>
        /// Reset Password
        /// </summary>
        /// <param name="resetPasswordModel"></param>
        /// <param name="tokenString"></param>
        /// <returns></returns>
       public async Task<Tuple<bool, string>> ResetPassword(ResetPasswordModel resetPasswordModel,string tokenString)
        {
            var token = new JwtSecurityToken(tokenString);

            //// Claims the email from token
            var Email =  (token.Claims.First(c => c.Type == "Email").Value);
          
            //// Find the Email in Database and return the result
            var user = await _userManager.FindByEmailAsync(Email);
            if (user != null)
            {
                //// this method generate the password reset token
                var resetToken = await _userManager.GeneratePasswordResetTokenAsync(user);

                //// Here ResetPasswordAsync() Specifies the new password after validating given password reset token
                var result = await _userManager.ResetPasswordAsync(user, resetToken, resetPasswordModel.Password);
               if(result != null)
                {
                    return Tuple.Create(true, "Password has been change");
                }
               else
                {
                    return Tuple.Create(false, "Password has not been change");
                }
            }
            else
            {
                return Tuple.Create(false, "User is not Exist ");
            }
        }
    }
}