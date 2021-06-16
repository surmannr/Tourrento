using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tourrento.DAL.Models;

namespace Tourrento.DAL.EntityConfigurations
{
    public class RentEntityConfiguration : IEntityTypeConfiguration<Rent>
    {
        public void Configure(EntityTypeBuilder<Rent> builder)
        {
            builder.HasData(
                new Rent()
                {
                    Id = 1,
                    RentalDate = DateTimeOffset.Now,
                    UntilDate = DateTimeOffset.Now.AddDays(1),
                    UserId = "seedtwo",
                    AcceptContract = true,
                    TotalPrice = 2000
                },
                 new Rent()
                 {
                     Id = 2,
                     RentalDate = DateTimeOffset.Now,
                     UntilDate = DateTimeOffset.Now.AddDays(1),
                     UserId = "seedthree",
                     AcceptContract = true,
                     TotalPrice = 3000
                 },
                  new Rent()
                  {
                      Id = 3,
                      RentalDate = DateTimeOffset.Now,
                      UntilDate = DateTimeOffset.Now.AddDays(1),
                      UserId = "seedtwo",
                      AcceptContract = true,
                      TotalPrice = 1000
                  }, 
                  new Rent()
                  {
                      Id = 4,
                      RentalDate = DateTimeOffset.Now,
                      UntilDate = DateTimeOffset.Now.AddDays(1),
                      UserId = "seedthree",
                      AcceptContract = true,
                      TotalPrice = 5000
                  }
            );
        }
    }
}
