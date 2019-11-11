﻿using BusinessLayer.Interface;
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
        public async Task<Tuple<bool, string>> AddUserDetails(UserDetails user)
        {
            try
            {
                //// If user the user details is empty or not 
                if (user != null)
                {
                    var result = await _registration.AddUserDetails(user);
                    if (result != null)
                    {
                        return Tuple.Create(true, "User registration Successful");
                    }
                    else
                    {
                        return Tuple.Create(false, "User registration is not Successful");
                    }

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


        /// <summary>
        /// Logins the specified login model.
        /// </summary>
        /// <param name="loginModel">The login model.</param>
        /// <returns></returns>
        /// <exception cref="NotImplementedException"></exception>
        public async Task<Tuple<string, string>> Login(LoginModel loginModel)
        {
            try
            {
                //// If login details is empty or not 
                if (loginModel != null)
                {
                    var LoginResult = await _registration.Login(loginModel);
                    return Tuple.Create(LoginResult.Item1, "Login Successful");
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

        /// <summary>
        /// Forgots the password.
        /// </summary>
        /// <param name="passwordModel">The password model.</param>
        /// <returns></returns>
        /// <exception cref="Exception">User Email is not valid</exception>
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

        /// <summary>
        /// Resets the password.
        /// </summary>
        /// <param name="resetPasswordModel">The reset password model.</param>
        /// <param name="tokenString">The token string.</param>
        /// <returns></returns>
        /// <exception cref="Exception">User Email is not valid</exception>
        public async Task<Tuple<bool, string>> ResetPassword(ResetPasswordModel resetPasswordModel, string tokenString)
        {
            try
            {
                if(resetPasswordModel != null)
                {
                   var result = await  _registration.ResetPassword(resetPasswordModel,tokenString);
                    if(result != null)
                    {
                        return Tuple.Create(true, "Password Has Been change");
                    }
                    else
                    {
                        return Tuple.Create(true, "Password Has not Been change");
                    }
                }
                else
                {
                    throw new Exception("User Email is not valid");
                }
            }
            catch(Exception ex)
            {
                throw ex;
            }
        }
    }
}

