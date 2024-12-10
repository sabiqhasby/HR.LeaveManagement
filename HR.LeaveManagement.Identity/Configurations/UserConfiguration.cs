using HR.LeaveManagement.Identity.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace HR.LeaveManagement.Identity.Configurations
{
   public class UserConfiguration : IEntityTypeConfiguration<ApplicationUser>
   {
      public void Configure(EntityTypeBuilder<ApplicationUser> builder)
      {
         var hasher = new PasswordHasher<ApplicationUser>();
         builder.HasData(
            new ApplicationUser
            {
               Id = "732478as-as4hf-44532-a5sdfh-3498sdhfshc9",
               Email = "admin@localhost.com",
               NormalizedEmail = "ADMIN@LOCALHOST.COM",
               FirstName = "System",
               LastName = "Admin",
               UserName = "admin@localhost.com",
               NormalizedUserName = "ADMIN@LOCALHOST.COM",
               PasswordHash = hasher.HashPassword(null, "P@ssword1"),
               EmailConfirmed = true
            },
            new ApplicationUser
            {
               Id = "732478as-as4hf-44s23-a5sdfh-3498sdhfshc9",
               Email = "user@localhost.com",
               NormalizedEmail = "USER@LOCALHOST.COM",
               FirstName = "System",
               LastName = "User",
               UserName = "user@localhost.com",
               NormalizedUserName = "USER@LOCALHOST.COM",
               PasswordHash = hasher.HashPassword(null, "P@ssword1"),
               EmailConfirmed = true
            }
            );
      }
   }
}
