using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace HR.LeaveManagement.Identity.Configurations
{
   public class RoleConfiguration : IEntityTypeConfiguration<IdentityRole>
   {
      public void Configure(EntityTypeBuilder<IdentityRole> builder)
      {
         builder.HasData(
            new IdentityRole
            {
               Id = "csvs453as6e-45xsd-baaf-12jasfzasdfkjf",
               Name = "Employee",
               NormalizedName = "EMPLOYEE"
            },
             new IdentityRole
             {
                Id = "csvs453as6e-45xse-baaf-12jasfzasdfkjf",
                Name = "Administrator",
                NormalizedName = "ADMINISTRATOR"
             }
            );
      }
   }
}
