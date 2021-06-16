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
    public class RoleEntityConfiguration : IEntityTypeConfiguration<IdentityRole>
    {
        public void Configure(EntityTypeBuilder<IdentityRole> builder)
        {
            builder.HasData(
                new IdentityRole() {
                    Id = Roles.Felhasznalo.ToUpper(),
                    ConcurrencyStamp = Guid.NewGuid().ToString(),
                    Name = Roles.Felhasznalo,
                    NormalizedName = Roles.Felhasznalo.ToUpper()
                },
                new IdentityRole()
                {
                    Id = Roles.Szervezo.ToUpper(),
                    ConcurrencyStamp = Guid.NewGuid().ToString(),
                    Name = Roles.Szervezo,
                    NormalizedName = Roles.Szervezo.ToUpper()
                },
                new IdentityRole()
                {
                    Id = Roles.Admin.ToUpper(),
                    ConcurrencyStamp = Guid.NewGuid().ToString(),
                    Name = Roles.Admin,
                    NormalizedName = Roles.Admin.ToUpper()
                }
            );
        }
    }
}
