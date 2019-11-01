using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BusinessLayer.Interface;
using CommonLayer.Model;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace FundooAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AccountController : ControllerBase
    {
        private IUserBL _user;

        public AccountController(IUserBL user)
        {
            this._user = user;
        }

        [HttpPost]
        public async Task<IActionResult> AddUserDeatil(UserModel model)
        {
            var result = await _user.AddUserDetail(model);
            return Ok(result);
        }
    }
}