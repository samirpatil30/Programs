using CommonLayer.Model;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Interface
{
   public interface IUserBL
    {
        Task<bool> AddUserDetail(UserModel model);
    }
}
