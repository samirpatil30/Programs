using CommanLayer.Model;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Interface
{
  public interface IAccountBL
    {
        Task<bool> AddUserDetails(UserDetails user);
    }
}
