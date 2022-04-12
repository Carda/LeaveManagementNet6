using LeaveManagementWeb.Constants;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace LeaveManagementWeb.Configuration.Entities
{
    public class RoleSeedConfiguration : IEntityTypeConfiguration<IdentityRole>
    {
        public void Configure(EntityTypeBuilder<IdentityRole> builder)
        {
            builder.HasData(
                 new IdentityRole
                 {
                     Id = "aedd2960-fefc-33d3-9bdb-650c04b2d9d2",
                     Name = Roles.Administrator,
                     NormalizedName = Roles.Administrator.ToUpper()
                 },
                 new IdentityRole
                 {
                     Id = "aedd3360-fefc-ccd3-9bdb-650c04b2d9d2",
                     Name = Roles.User,
                     NormalizedName = Roles.User.ToUpper()
                 }
                );
        }
    }
}