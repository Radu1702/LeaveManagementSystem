using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace LeaveManagementSystem2.Data.Configurations
{
    public class ApplicationUserConfiguration : IEntityTypeConfiguration<ApplicationUser>
    {
        public void Configure(EntityTypeBuilder<ApplicationUser> builder)
        {
            var hasher = new PasswordHasher<ApplicationUser>();
            builder.HasData(new ApplicationUser
            {
                Id = "efe2f997-3bef-4396-a1a7-6ad83c127584",
                Email = "admin@localhost.com",
                NormalizedEmail = "ADMIN@LOCALHOST.COM",
                NormalizedUserName = "ADMIN@LOCALHOST.COM",
                UserName = "admin@localhost.com",
                PasswordHash = hasher.HashPassword(null, "P@ssword1"),
                EmailConfirmed = true,
                FirstName = "Default",
                LastName = "Admin",
                DateOfBirth = new DateOnly(1990, 1, 1)
            });
        }
    }
}
