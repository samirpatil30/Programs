﻿

namespace FundoTestProject.Account
{
    using BusinessLayer.Services;
    using CommanLayer.Model;
    using Moq;
    using RepositoryLayer.Interface;
    using Xunit;

    /// <summary>
    /// UserAccountTesting
    /// </summary>
    public class UserAccountTesting
    {
        [Fact]
        public void RegistrationTesting()
        {
            //// Using Mock create the instance of IUserRegistrationRepository
            var repositoryLayer = new Mock<IUserRegistraionRepository>();
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

        /// <summary>
        /// Logins this instance.
        /// </summary>
        [Fact]
        public void Login()
        {
            var Repository = new Mock<IUserRegistraionRepository>();
            var businessLayer = new UserRegistrationService(Repository.Object);
            var model = new LoginModel()
            {
                UserName = "userName",
                Password = "Password"
            };

            var data = businessLayer.Login(model);

            Assert.NotNull(data);
        }

        /// <summary>
        /// Forgots the password.
        /// </summary>
        [Fact]
        public void ForgotPassword()
        {
            var Repository = new Mock<IUserRegistraionRepository>();
            var businessLayer = new UserRegistrationService(Repository.Object);
            var model = new ForgotPasswordModel()
            {
                Email = "Email"
            };

            var data = businessLayer.ForgotPassword(model);
            Assert.NotNull(data);
        }

        /// <summary>
        /// Resets the password.
        /// </summary>
        [Fact]
        public void ResetPassword()
        {
            var Repository = new Mock<IUserRegistraionRepository>();
            var Business = new UserRegistrationService(Repository.Object);
            var model = new ResetPasswordModel()
            {
                Password = "Password"
            };

            var data = Business.ResetPassword(model, "Reset Password");
            Assert.NotNull(data);
        }
    }
}