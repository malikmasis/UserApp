using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using System.Linq;
using System.Web;
using UserApp.Models;

namespace UserApp.DBContext
{
    public class UserAppContext : DbContext
    {

        public UserAppContext() : base("UserAppContext")
        {
        }

        public DbSet<User> User { get; set; }
        public DbSet<Address> Address { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
        }
    }
}