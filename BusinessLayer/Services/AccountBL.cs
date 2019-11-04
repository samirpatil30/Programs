using BusinessLayer.Interface;
using CommanLayer.Model;
using RepositoryLayer.Interface;
using RepositoryLayer.Services;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Services
{
    /// <summary>
    /// AccountBL
    /// </summary>
    /// <seealso cref="BusinessLayer.Interface.IAccountBL" />
    public class AccountBL : IAccountBL
    {
        /// <summary>
        /// Create the reference variable of Repository layer interface i.e IRegistrationRl
        /// </summary>
        private IRegistraionRl _registration;

        /// <summary>
        /// Initializes a new instance of the <see cref="AccountBL"/> class.
        /// </summary>
        /// <param name="registration">The registration.</param>
        public AccountBL(IRegistraionRl registration)
        {
            _registration = registration;
        }

        /// <summary>
        /// Adds the user details.
        /// </summary>
        /// <param name="user">The user.</param>
        /// <returns></returns>
        /// <exception cref="Exception">User is empty</exception>
        public async Task<bool> AddUserDetails(UserDetails user)
        {
            try
            {
                if(user != null)
                {
                   return await _registration.AddUserDetails(user);
                }
                else
                {
                    throw new Exception("User is empty");
                }
            }
            catch(Exception exception)
            {
                throw exception;
            }
        }


        /// <summary>
        /// Logins the specified login model.
        /// </summary>
        /// <param name="loginModel">The login model.</param>
        /// <returns></returns>
        /// <exception cref="NotImplementedException"></exception>
        public async Task<string> Login(LoginModel loginModel)
        {
            try
            {
                if (loginModel != null)
                {
                    return await _registration.Login(loginModel);
                }
                else
                {
                    throw new Exception("User is empty");
                }
            }
            catch (Exception exception)
            {
                throw exception;
            }
        }
    }
}
