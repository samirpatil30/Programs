using BusinessLayer.Interface;
using CommonLayer.Model;
using RepositoryLayer.Interface;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Service
{
    public class UserBl : IUserBL
    {
        private readonly IUserRepository _repository;
        public UserBl(IUserRepository repository)
        {
            this._repository = repository;
        }
        public Task<bool> AddUserDetail(UserModel model)
        {
            try
            {
                if (model != null)
                {
                    return _repository.AddUserDetails(model);
                }
                else
                {
                    throw new Exception("Empty Details");
                }
            }
            catch (Exception exception)
            {
                throw exception;
            }
        }
    }
}
