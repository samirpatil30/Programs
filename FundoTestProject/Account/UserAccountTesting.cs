using BusinessLayer.Services;
using CommanLayer.Model;
using Moq;
using RepositoryLayer.Interface;
using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace FundoTestProject.Account
{
    public class UserAccountTesting
    {
        [Fact]
        public void RegistrationTesting()
        {
            var repositoryLayer = new Mock<IUserRegistraionRepositpry>();
            var businessLayer = new UserRegistrationService(repositoryLayer.Object);
            var model = new UserDetails()
            {
                FirstName = "FirstName",
                LastName = "LastName",
                UserName = "UserName",
                Email = "Email",
                Password = "Password",
                ProfilePicuture = "ProfilePicuture"
            };

            ////Act
            var data = businessLayer.AddUserDetails(model);

            //// Assert
            Assert.NotNull(data);
        }

        [Fact]
        public void Login()
        {
            var Repository = new Mock<IUserRegistraionRepositpry>();
            var businessLayer = new UserRegistrationService(Repository.Object);
            var model = new LoginModel()
            {
                UserName = "userName",
                Password = "Password"
            };

            var data = businessLayer.Login(model);

            Assert.NotNull(data);
        }

        [Fact]
        public void ForgotPassword()
        {
            var Repository = new Mock<IUserRegistraionRepositpry>();
            var businessLayer = new UserRegistrationService(Repository.Object);
            var model = new ForgotPasswordModel()
            {
                Email = "Email"
            };

            var data = businessLayer.ForgotPassword(model);
            Assert.NotNull(data);
        }

        [Fact]
        public void ResetPassword()
        {
            var Repository = new Mock<IUserRegistraionRepositpry>();
            var Business = new UserRegistrationService(Repository.Object);
            var model = new ResetPasswordModel()
            {
                Password = "Password"
            };

            var data = Business.ResetPassword(model,"Reset Password");
            Assert.NotNull(data);
        }
    }
}
