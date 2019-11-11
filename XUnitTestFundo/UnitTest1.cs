using CommanLayer.Model;
using Moq;
using RepositoryLayer.Services;
using System;
using Xunit;

namespace XUnitTestFundo
{
    public class UnitTest1
    {
        /// <summary>
        /// Logins this instance.
        /// </summary>
        [Fact]
        public void login()
        {
            ////Arrange
            var loginDetails = new Mock<UserRegistrationRepository>();
            var login = new AccountManager(loginDetails)
                    var loginModel = new LoginModel();
            {
                UserName = "UserName";
                ForgotPasswordModel = "Password";
            };

            ////Assert
            var result = login.Login(loginModel);
            Assert.NotNull(result);


        }
    }
}
