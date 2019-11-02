using CommanLayer.Model;
using Microsoft.AspNetCore.Identity;
using RepositoryLayer.Interface;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace RepositoryLayer.Services
{
    public class RegistrationRL : IRegistraionRl
    {
        private UserManager<ApplicationUser> _userManager;
       
        public RegistrationRL(UserManager<ApplicationUser> userManager)
        {
            this._userManager = userManager;
        }

        public async Task<bool> AddUserDetails(UserDetails user)
        {

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

       public Task<bool> Login()
        {

        }
    }
}
