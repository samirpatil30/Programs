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
    [Route("api/[controller]")]
    [ApiController]
    public class AccountController : ControllerBase
    {
        private IAccountBL _account;
        public AccountController(IAccountBL account)
        {
            _account = account;
        }

        [HttpPost]
        [Route("Add")]

        public async Task<bool> AddUserDetail(UserDetails details)
        {
            var result = await _account.AddUserDetails(details);
            return result;
        }
    }
}