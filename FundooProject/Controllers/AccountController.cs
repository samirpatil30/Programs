// --------------------------------------------------------------------------------------------------------------------
// <copyright file="AccountController.cs" company="Bridgelabz">
//   Copyright © 2018 Company
// </copyright>
// <creator name="Samir Patil"/>
// --------------------------------------------------------------------------------------------------------------------
namespace FundooProject.Controllers
{
    using System;
    using System.Collections.Generic;
    using System.Threading.Tasks;
    using BusinessLayer.Interface;
    using CommanLayer.Model;
    using Microsoft.AspNetCore.Http;
    using Microsoft.AspNetCore.Mvc;

    /// <summary>
    /// Account Controller
    /// </summary>
    /// <seealso cref="Microsoft.AspNetCore.Mvc.ControllerBase" />
    [Route("api/[controller]")]
    //[ApiController]
    public class AccountController : ControllerBase
    {
        /// <summary>
        /// The account
        /// </summary>
        private IUserRegistrationBusiness _account;

        /// <summary>
        /// Initializes a new instance of the <see cref="AccountController"/> class.
        /// </summary>
        /// <param name="account">The account.</param>
        public AccountController(IUserRegistrationBusiness account)
        {
            this._account = account;
        }

        /// <summary>
        /// Adds the user detail.
        /// </summary>
        /// <param name="details">The details.</param>
        /// <returns>result</returns>
        [HttpPost]
        [Route("Add")]
        public async Task<IActionResult> AddUserDetail(UserDetails details)
        {
            //// the variable result stores the result of method AddUserDetails          
            var result = await this._account.AddUserDetails(details);
            return this.Ok(new { result });
        }

        /// <summary>
        /// Logins the specified details.
        /// </summary>
        /// <param name="details">The details.</param>
        /// <returns>ResultOfLogin</returns>
        [HttpPost]
        [Route("login")]
        public async Task<Tuple<string, string>> Login(LoginModel details)
        {
            //// the variable result stores the result of method Login
            var ResultOfLogin = await this._account.Login(details);
            return Tuple.Create(ResultOfLogin.Item1, "Login Successful");
        }

        /// <summary>
        /// Forgot the password.
        /// </summary>
        /// <param name="passwordModel">The password model.</param>
        /// <returns>passwordModel</returns>
        [HttpPost]
        [Route("ForgotPassword")]
        public async Task<string> ForgotPasword(ForgotPasswordModel passwordModel)
        {
            //// the variable result stores the result of method Login
            return await this._account.ForgotPassword(passwordModel);
        }

        /// <summary>
        /// Resets the password.
        /// </summary>
        /// <param name="resetPasswordModel">The reset password model.</param>
        /// <param name="tokenString">The token string.</param>
        /// <returns>result</returns>
        [HttpPost]
        [Route("Reset/{tokenString}")]
        public async Task<IActionResult> ResetPassword(ResetPasswordModel resetPasswordModel, string tokenString)
        {
            var result = await this._account.ResetPassword(resetPasswordModel, tokenString);
            return this.Ok(new { result });
        }

        /// <summary>
        /// Profiles the picture.
        /// </summary>
        /// <param name="userId">The user identifier.</param>
        /// <param name="file">The file.</param>
        /// <returns>UrlOfProfilePicture</returns>
        [HttpPost]
        [Route("ProfilePicture")]
        public IActionResult ProfilePicture(string userId, IFormFile file)
        {
            var UrlOfProfilePicture = this._account.ProfilePicture(userId, file);
            return this.Ok(new { UrlOfProfilePicture });
        }

        [HttpPost]
        [Route("adminRegistration")]

        public async Task<IActionResult> AdminRegistration(UserDetails adminDetails)
        {
            var result = await _account.AdminRegistration(adminDetails);
            return Ok(new { result });
        }

        [HttpPost]
        [Route("adminLogin")]

        public async Task<IActionResult> AdminLogin(LoginModel loginModel)
        {
            var AdminToken = await _account.AdminLogin(loginModel);
            return Ok(new { AdminToken });
        }

        [HttpGet]
        [Route("statitics")]
        public Dictionary<string, int> UserStaticstics()
        {
            return _account.UserStaticstics();
        }

        [HttpGet]
        [Route("list of Users")]

        public IList<UserDetails> ListOfUsers()
        {
           return _account.ListOfUsers();        
        }
    }
}  