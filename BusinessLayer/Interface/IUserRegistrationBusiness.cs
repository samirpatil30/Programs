// --------------------------------------------------------------------------------------------------------------------
// <copyright file="IUserRegistrationBusiness.cs" company="Bridgelabz">
//   Copyright © 2018 Company
// </copyright>
// <creator name="Samir Patil"/>
// --------------------------------------------------------------------------------------------------------------------
namespace BusinessLayer.Interface
{
    using CommanLayer.Model;
    using Microsoft.AspNetCore.Http;
    using System;
    using System.Collections.Generic;
    using System.Threading.Tasks;

    /// <summary>
    /// IAccountBL
    /// </summary>
    public interface IUserRegistrationBusiness
    {
        /// <summary>
        /// Adds the user details.
        /// </summary>
        /// <param name="user">The user.</param>
        /// <returns>result</returns>
        Task<Tuple<bool, string>> AddUserDetails(UserDetails user);

        /// <summary>
        /// Logins the specified login model.
        /// </summary>
        /// <param name="loginModel">The login model.</param>
        /// <returns></returns>
        Task<Tuple<string, string>> Login(LoginModel loginModel);

        /// <summary>
        /// Forgot password.
        /// </summary>
        /// <param name="passwordModel">The password model.</param>
        /// <returns>passwordModel</returns>
        Task<string> ForgotPassword(ForgotPasswordModel passwordModel);

        /// <summary>
        /// Reset password.
        /// </summary>
        /// <param name="resetPasswordModel">The reset password model.</param>
        /// <param name="tokenString">The token string.</param>
        /// <returns>resetPasswordModel,tokenString </returns>
        Task<Tuple<bool, string>> ResetPassword(ResetPasswordModel resetPasswordModel, string tokenString);

        /// <summary>
        /// Profiles the picture.
        /// </summary>
        /// <param name="userid">The user id.</param>
        /// <param name="file">The file.</param>
        /// <returns>User id, file</returns>
        string ProfilePicture(string userid, IFormFile file);
        Task<bool> AdminRegistration(UserDetails adminDetails);
        Task<string> AdminLogin(LoginModel loginModel);
        Dictionary<string, int> UserStaticstics();
        IList<UserDetails> ListOfUsers();
    }
}
