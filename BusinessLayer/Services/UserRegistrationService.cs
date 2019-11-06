using BusinessLayer.Interface;
using CommanLayer.Model;
using RepositoryLayer.Interface;
using System;
using System.Threading.Tasks;

namespace BusinessLayer.Services
{
    /// <summary>
    /// AccountBL
    /// </summary>
    /// <seealso cref="BusinessLayer.Interface.IUserRegistrationBusiness" />
    public class UserRegistrationService : IUserRegistrationBusiness
    {
        /// <summary>
        /// Create the reference variable of Repository layer interface i.e IRegistrationRl
        /// </summary>
        private IUserRegistraionRepositpry _registration;

        /// <summary>
        /// Initializes a new instance of the <see cref="UserRegistrationService"/> class.
        /// </summary>
        /// <param name="registration">The registration.</param>
        public UserRegistrationService(IUserRegistraionRepositpry registration)
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
                //// If user the user details is empty or not 
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
                //// If login details is empty or not 
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

       public async Task<string> ForgotPassword(ForgotPasswordModel passwordModel)
        {
            try
            {
                //// If login details is empty or not 
                if (passwordModel != null)
                {
                    return await _registration.ForgotPassword(passwordModel);
                }
                else
                {
                    throw new Exception("User Email is not valid");
                }
            }
            catch (Exception exception)
            {
                throw exception;
            }
        }
    }
}
