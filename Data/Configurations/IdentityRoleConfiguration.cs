using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;

namespace LeaveManagementSystem2.Data.Configurations
{
    public class IdentityRoleConfiguration : IEntityTypeConfiguration<IdentityRole>
    {
        public void Configure(Microsoft.EntityFrameworkCore.Metadata.Builders.EntityTypeBuilder<IdentityRole> builder)
        {
            builder.HasData(
               new IdentityRole
               {
                   Id = "cdef1c32-a3ae-4b89-959e-7dacc4071812",
                   Name = "Employee",
                   NormalizedName = "EMPLOYEE",
               },
               new IdentityRole
               {
                   Id = "d7992d20-4c09-4757-ad22-66ea5fe6aa1a",
                   Name = "Supervisor",
                   NormalizedName = "SUPERVISOR",
               },
               new IdentityRole
               {
                   Id = "8d3bef90-ffd2-41c8-9bc3-70509bbd3618",
                   Name = "Administrator",
                   NormalizedName = "ADMINISTRATOR",
               }
           );
        }
    }
}
