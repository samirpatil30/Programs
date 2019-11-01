using CommonLayer.Model;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace RepositoryLayer.Interface
{
   public interface IUserRepository
    {
        Task<bool> AddUserDetails(UserModel detail);
    }
}
