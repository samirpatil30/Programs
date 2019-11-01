using CommonLayer.Model;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace RepositoryLayer.Context
{
   public class AuthenticationUserContext : DbContext
    {
        public AuthenticationUserContext(DbContextOptions db) : base(db)
        {

        }

        public DbSet<UserModel> userModels { get; set; }
    }
}
