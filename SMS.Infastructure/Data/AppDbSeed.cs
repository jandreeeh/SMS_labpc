using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using SMS.Domain;

namespace SMS.Infastructure.Data
{
    public class AppDbSeed
    {
        public static void SeedUsers(ModelBuilder builder)
        {
            var passwordHasher = new PasswordHasher<AppUser>();

            var appUser = new AppUser
            {
                Id = Guid.NewGuid().ToString(),
                PasswordHash = passwordHasher.HashPassword(null, "admin"),
            };

            builder.Entity<AppUser>().HasData(appUser); 
        }
    }
}
