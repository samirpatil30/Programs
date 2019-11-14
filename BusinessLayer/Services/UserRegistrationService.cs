// --------------------------------------------------------------------------------------------------------------------
// <copyright file="UserRegistrationService.cs" company="Bridgelabz">
//   Copyright © 2018 Company
// </copyright>
// <creator name="Samir Patil"/>
// --------------------------------------------------------------------------------------------------------------------
namespace BusinessLayer.Services
{
    using BusinessLayer.Interface;
    using CommanLayer.Model;
    using Microsoft.AspNetCore.Http;
    using RepositoryLayer.Interface;
    using System;
    using System.Threading.Tasks;

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
                //// If checks login details is empty or not 
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
                //// If checks passwordModel details is empty or not 
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
                //// If checks resetPasswordModel details is empty or not 
                if (resetPasswordModel != null)
                {
                    //// variable result stores the result of ResetPassword()
                   var result = await  _registration.ResetPassword(resetPasswordModel,tokenString);

                    //// If checks result is null or not
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

       public string ProfilePicture( string userid, IFormFile file)
        {
            try
            {
                CloudinaryImageUpload cloudinary = new CloudinaryImageUpload();
                var profilePicUrl = cloudinary.UploadImageOnCloud(file);
                if(userid != null)
                {
                    return _registration.ProfilePicture(profilePicUrl, userid, file);
                }
                else
                {
                    return "Profile Picture is not uploaded";
                }
            }
            catch(Exception exception)
            {
                throw exception;
            }
        }
    }
}