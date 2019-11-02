using CommanLayer.Model;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace RepositoryLayer.Interface
{
   public interface IRegistraionRl
    {
        Task<bool> AddUserDetails(UserDetails user);
    }
}
