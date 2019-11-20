using CommanLayer.Model;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace RepositoryLayer.Context
{
   public class AuthenticationContext : IdentityDbContext
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="AuthenticationContext"/> class.
        /// </summary>
        /// <param name="options">The options to be used by a <see cref="T:Microsoft.EntityFrameworkCore.DbContext" />.</param>
        public AuthenticationContext(DbContextOptions options) : base(options)
        {
        }

        /// <summary>
        /// Gets or sets the user.
        /// </summary>
        /// <value>
        /// The user.
        /// </value>
        public DbSet<ApplicationUser> User { get; set; }

        public DbSet<NotesModel> notesModels { get; set; }
        public DbSet<LabelModel> labelModels { get; set; }

        public DbSet<CollabrationModel> Collabrations { get; set; }
        public DbSet<SearchModel> searches { get; set; }
    }
}
