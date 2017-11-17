using Microsoft.AspNet.Identity;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ABB_Portal.Models.ABBEntityModels.Initializers
{
    public class UserSeeder: CreateDatabaseIfNotExists<ApplicationDbContext>
    {
        protected override void Seed(ApplicationDbContext context)
        {
            //  This method will be called after migrating to the latest version.

            var passwordHash = new PasswordHasher();
            string password = passwordHash.HashPassword("Password@123");
            
               ApplicationUser au =  new ApplicationUser
                {
                    UserName = "Steve@Steve.com",
                    PasswordHash = password,
                    PhoneNumber = "08869879"

                };
            context.Users.Add(au);
            context.SaveChanges();

        }
    }
}
