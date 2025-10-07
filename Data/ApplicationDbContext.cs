using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace LeaveManagementSystem2.Data
{
    public class ApplicationDbContext : IdentityDbContext<ApplicationUser>
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
            builder.Entity<IdentityRole>().HasData(
                new IdentityRole
                {
                    Id = "cdef1c32-a3ae-4b89-959e-7dacc4071812",
                    Name = "Employee",
                    NormalizedName = "EMPLOYEE",
                },
                new IdentityRole {
                    Id = "d7992d20-4c09-4757-ad22-66ea5fe6aa1a",
                    Name = "Supervisor",
                    NormalizedName = "SUPERVISOR",
                },
                new IdentityRole {
                    Id = "8d3bef90-ffd2-41c8-9bc3-70509bbd3618",
                    Name = "Administrator",
                    NormalizedName = "ADMINISTRATOR",
                }
            );

            var hasher = new PasswordHasher<ApplicationUser>();
            builder.Entity<ApplicationUser>().HasData(new ApplicationUser
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

            builder.Entity<IdentityUserRole<string>>().HasData(
                new IdentityUserRole<string>
                {
                    RoleId = "8d3bef90-ffd2-41c8-9bc3-70509bbd3618",
                    UserId = "efe2f997-3bef-4396-a1a7-6ad83c127584"
                }
            );
        }

        public DbSet<LeaveType> LeaveTypes { get; set; }
        
        public DbSet<LeaveAllocation> LeaveAllocations { get; set; }

        public DbSet<Period> Periods { get; set; }
        }
}
