using BusinessLayer.Interface;
using CommanLayer.Model;
using RepositoryLayer.Interface;
using RepositoryLayer.Services;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Services
{
    public class AccountBL : IAccountBL
    {
        private IRegistraionRl _registration;

        public AccountBL(IRegistraionRl registration)
        {
            _registration = registration;
        }

        public async Task<bool> AddUserDetails(UserDetails user)
        {
            try
            {
                if(user != null)
                {
                   return await _registration.AddUserDetails(user);
                }
                else
                {
                    throw new Exception("User is empty");
                }
            }
            catch(Exception exception)
            {
                throw exception;
            }
        }
    }
}
