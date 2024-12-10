using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace HR.LeaveManagement.Identity.Configurations
{
   public class UserRoleConfiguration : IEntityTypeConfiguration<IdentityUserRole<string>>
   {

      public void Configure(EntityTypeBuilder<IdentityUserRole<string>> builder)
      {
         builder.HasData(
            new IdentityUserRole<string>
            {
               RoleId = "csvs453as6e-45xsd-baaf-12jasfzasdfkjf",
               UserId = "732478as-as4hf-44s23-a5sdfh-3498sdhfshc9"
            },
            new IdentityUserRole<string>
            {
               RoleId = "csvs453as6e-45xse-baaf-12jasfzasdfkjf",
               UserId = "732478as-as4hf-44532-a5sdfh-3498sdhfshc9"
            }
            );
      }
   }
}
