using CommanLayer.Model;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Interface
{
    /// <summary>
    /// IAccountBL
    /// </summary>
    public interface IUserRegistrationBusiness
    {
        /// <summary>
        /// Adds the user details.
        /// </summary>
        /// <param name="user">The user.</param>
        /// <returns></returns>
        Task<Tuple<bool, string>> AddUserDetails(UserDetails user);

        /// <summary>
        /// Logins the specified login model.
        /// </summary>
        /// <param name="loginModel">The login model.</param>
        /// <returns></returns>
        Task<Tuple<string, string>> Login(LoginModel loginModel);

        /// <summary>
        /// Forgots the password.
        /// </summary>
        /// <param name="passwordModel">The password model.</param>
        /// <returns></returns>
        Task<string> ForgotPassword(ForgotPasswordModel passwordModel);

        /// <summary>
        /// Resets the password.
        /// </summary>
        /// <param name="resetPasswordModel">The reset password model.</param>
        /// <param name="tokenString">The token string.</param>
        /// <returns></returns>
        Task<Tuple<bool, string>> ResetPassword(ResetPasswordModel resetPasswordModel, string tokenString);
    }
}
