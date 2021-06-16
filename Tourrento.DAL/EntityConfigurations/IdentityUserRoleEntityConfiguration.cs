using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tourrento.Shared.Constants;

namespace Tourrento.DAL.EntityConfigurations
{
    public class IdentityUserRoleEntityConfiguration : IEntityTypeConfiguration<IdentityUserRole<string>>
    {
        public void Configure(EntityTypeBuilder<IdentityUserRole<string>> builder)
        {
            builder.HasData(
                new IdentityUserRole<string>() { UserId = "admin", RoleId = Roles.Admin },
                 new IdentityUserRole<string>() { UserId = "seedone", RoleId = Roles.Szervezo },
                 new IdentityUserRole<string>() { UserId = "seedtwo", RoleId = Roles.Felhasznalo },
                 new IdentityUserRole<string>() { UserId = "seedthree", RoleId = Roles.Felhasznalo }
            );
        }
    }
}
