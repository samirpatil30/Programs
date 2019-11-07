using CommanLayer.Model;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace RepositoryLayer.Interface
{
   public interface IUserRegistraionRepositpry
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

        Task<string> ForgotPassword(ForgotPasswordModel passwordModel);

        Task<Tuple<bool,string>> ResetPassword(ResetPasswordModel resetPasswordModel, string tokenString);
    }
}
