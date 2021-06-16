using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tourrento.DAL.Models.JoinTables;

namespace Tourrento.DAL.EntityConfigurations.Joins
{
    public class ParticipateTourEntityConfiguration : IEntityTypeConfiguration<ParticipateTour>
    {
        public void Configure(EntityTypeBuilder<ParticipateTour> builder)
        {
            builder.HasData(
                new ParticipateTour()
                {
                    TourId = 1,
                    UserId = "seedtwo",
                    Price = 1500,
                    IsPaid = false
                },
                new ParticipateTour()
                {
                    TourId = 2,
                    UserId = "seedthree",
                    Price = 1700,
                    IsPaid = true
                },
                new ParticipateTour()
                {
                    TourId = 3,
                    UserId = "seedtwo",
                    Price = 1200,
                    IsPaid = true
                },
                new ParticipateTour()
                {
                    TourId = 4,
                    UserId = "seedthree",
                    Price = 1800,
                    IsPaid = false
                }
            );
        }
    }
}
