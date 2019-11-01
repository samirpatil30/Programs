using CommonLayer.Model;
using Microsoft.AspNetCore.Identity;
using RepositoryLayer.Context;
using RepositoryLayer.Interface;
using System.Threading.Tasks;

namespace RepositoryLayer.Service
{
    public class UserRepository : IUserRepository
    {
        private readonly UserManager<ApplicationUser> userManager;
        private readonly AuthenticationUserContext authenticationContext;

        public UserRepository(UserManager<ApplicationUser> userManager, AuthenticationUserContext authenticationContext)
        {
            this.userManager = userManager;
            this.authenticationContext = authenticationContext;
        }
        public async Task<bool> AddUserDetails(UserModel detail)
        {
            ApplicationUser model = new ApplicationUser()
            {
                Name = detail.Name,
                LastName = detail.LastName,
                Email = detail.Email,
                PhoneNumber = detail.MobileNumber,
            };
            var result = await userManager.CreateAsync(model, detail.Password);
            return result.Succeeded;
        }
    }
}
