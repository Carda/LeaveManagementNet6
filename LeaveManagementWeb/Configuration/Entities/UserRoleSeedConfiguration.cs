using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace LeaveManagementWeb.Data
{
    public class UserRoleSeedConfiguration : IEntityTypeConfiguration<IdentityUserRole<string>>
    {
        public void Configure(EntityTypeBuilder<IdentityUserRole<string>> builder)
        {
            builder.HasData(
                new IdentityUserRole<string>
                {
                    RoleId= "aedd2960-fefc-33d3-9bdb-650c04b2d9d2",
                    UserId= "aedd2960-fefc-45d3-9bdb-650c04b2d9d2"
                },
                new IdentityUserRole<string>
                {
                    RoleId= "aedd3360-fefc-ccd3-9bdb-650c04b2d9d2",
                    UserId= "aedd2960-fefc-45d3-8bdb-650c04b2d9d2"
                }
            );
        }
    }
}