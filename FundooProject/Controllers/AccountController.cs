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
        private IAccountBL _account;

        /// <summary>
        /// Initializes a new instance of the <see cref="AccountController"/> class.
        /// </summary>
        /// <param name="account">The account.</param>
        public AccountController(IAccountBL account)
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
        public async Task<bool> AddUserDetail(UserDetails details)
        {
            //// the variable result stores the result of method AddUserDetails
            var result = await _account.AddUserDetails(details);
            return result;
        }

        [HttpPost]
        [Route("login")]
        public async Task<string> Login(LoginModel details)
        {  
            //// the variable result stores the result of method Login
            var result = await _account.Login(details);
            return result;
        }
    }
}