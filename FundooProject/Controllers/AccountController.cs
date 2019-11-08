using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BusinessLayer.Interface;
using CommanLayer.Model;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using RepositoryLayer.Context;

namespace FundooProject.Controllers
{
    /// <summary>
    /// AccountController
    /// </summary>
    /// <seealso cref="Microsoft.AspNetCore.Mvc.ControllerBase" />
    [Route("api/[controller]")]
    [ApiController]
    public class AccountController : ControllerBase
    {
        /// <summary>
        /// Create the instance variable of Business LayerInterface i.e IAccountBL
        /// </summary>
        private IUserRegistrationBusiness _account;

        /// <summary>
        /// Initializes a new instance of the <see cref="AccountController"/> class.
        /// </summary>
        /// <param name="account">The account.</param>
        public AccountController(IUserRegistrationBusiness account)
        {
            _account = account;
        }

        /// <summary>
        /// Adds the user detail.
        /// </summary>
        /// <param name="details">The details.</param>
        /// <returns></returns>
        [HttpPost]
        [Route("Add")]
        public async Task<IActionResult> AddUserDetail(UserDetails details)
         
        {
            //// the variable result stores the result of method AddUserDetails          
             var result = await _account.AddUserDetails(details);
             bool RegistrationStatus = true;
             return Ok(new { result, RegistrationStatus });   
        }

        [HttpPost]
        [Route("login")]
        public async Task<Tuple<string, string>> Login(LoginModel details)
        {  
            //// the variable result stores the result of method Login
            var ResultOfLogin = await _account.Login(details);
            return Tuple.Create(ResultOfLogin.Item1, "Login Successful");
        }

        [HttpPost]
        [Route("ForgotPassword")]
        public async Task<string> ForgotPasword(ForgotPasswordModel passwordModel)
        {
            //// the variable result stores the result of method Login
            return await _account.ForgotPassword(passwordModel); 
        }

        [HttpPost]
        [Route("Reset/{tokenString}")]
        public async Task<IActionResult> ResetPassword(ResetPasswordModel resetPasswordModel, string tokenString)
        {            
            var result = await _account.ResetPassword(resetPasswordModel, tokenString);
            return Ok(new { result });
        }


    }
}  