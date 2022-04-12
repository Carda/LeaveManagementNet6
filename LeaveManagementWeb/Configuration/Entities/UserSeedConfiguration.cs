using LeaveManagementWeb.Data;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace LeaveManagementWeb.Configuration.Entities
{
    public class UserSeedConfiguration : IEntityTypeConfiguration<Employee>
    {
        public void Configure(EntityTypeBuilder<Employee> builder)
        {
            var hasher = new PasswordHasher<Employee>();
            builder.HasData(
                new Employee
                {
                    Id= "aedd2960-fefc-45d3-9bdb-650c04b2d9d2",
                    Email= "cagdas.arda@live.com",
                    NormalizedEmail= "CAGDAS.ARDA@LIVE.COM",
                    NormalizedUserName= "CAGDAS.ARDA@LIVE.COM",
                    UserName= "cagdas.arda@live.com",
                    FirstName = "System",
                    LastName= "Admin",
                    PasswordHash= hasher.HashPassword(null, "u8p@xfyukBG5YC!"),
                    EmailConfirmed= true
                    
                },
                new Employee
                {
                    Id = "aedd2960-fefc-45d3-8bdb-650c04b2d9d2",
                    Email = "cagdas.arda1@live.com",
                    NormalizedEmail = "CAGDAS.ARDA1@LIVE.COM",
                    NormalizedUserName = "CAGDAS.ARDA1@LIVE.COM",
                    UserName = "cagdas.arda1@live.com",
                    FirstName = "User",
                    LastName = "Admin",
                    PasswordHash = hasher.HashPassword(null, "u8p@xfyukBG5YC!"),
                    EmailConfirmed = true
                }
            );
        }
    }
}