using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace LeaveManagementSystem2.Data.Configurations
{
    public class IdentityUserRoleConfiguration : IEntityTypeConfiguration<IdentityUserRole<string>>
    {
        public void Configure(EntityTypeBuilder<IdentityUserRole<string>> builder)
        {
            builder.HasData(
               new IdentityUserRole<string>
               {
                   RoleId = "8d3bef90-ffd2-41c8-9bc3-70509bbd3618",
                   UserId = "efe2f997-3bef-4396-a1a7-6ad83c127584"
               }
           );
        }
    }
}
