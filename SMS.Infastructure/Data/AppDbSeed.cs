using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using SMS.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SMS.Infastructure.Data
{
    public class AppDbSeed
    {
        public static void SeedUsers(ModelBuilder builder)
        {
            var passwordHasher = new PasswordHasher<AppUser>();

            var appUser = new AppUser{
                Id = Guid.NewGuid().ToString(),
                UserName = "admin", 
                PasswordHash = passwordHasher.HashPassword(null, "admin"),
            };

            builder.Entity<AppUser>().HasData(appUser);

        }
    }
}
