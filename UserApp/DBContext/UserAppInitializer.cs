using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using UserApp.Models;

namespace UserApp.DBContext
{
    public class UserAppInitializer : System.Data.Entity.DropCreateDatabaseIfModelChanges<UserAppContext>
    {
        protected override void Seed(UserAppContext context)
        {
            var users = new List<User>
            {
                new User{FirstMidName="Carson",LastName="Alexander",Birthday=DateTime.Parse("2005-09-01")}
            };

            users.ForEach(s => context.User.Add(s));
            context.SaveChanges();

            var courses = new List<Address>
            {
                new Address{UserId=1,Name="Ev Adresi",AddressType=AddressType.Home},
                new Address{UserId=1,Name="İş Adresi",AddressType=AddressType.Work},
            };
            courses.ForEach(s => context.Address.Add(s));
            context.SaveChanges();

            context.SaveChanges();
        }
    }
}