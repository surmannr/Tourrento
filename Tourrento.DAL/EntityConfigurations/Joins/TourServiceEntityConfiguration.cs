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
    public class TourServiceEntityConfiguration : IEntityTypeConfiguration<TourService>
    {
        public void Configure(EntityTypeBuilder<TourService> builder)
        {
            builder.HasData(
                new TourService()
                {
                    TourId = 1,
                    ServiceId = 1
                },
                new TourService()
                {
                    TourId = 1,
                    ServiceId = 2
                },
                new TourService()
                {
                    TourId = 2,
                    ServiceId = 1
                },
                new TourService()
                {
                    TourId = 2,
                    ServiceId = 2
                },
                new TourService()
                {
                    TourId = 3,
                    ServiceId = 1
                },
                new TourService()
                {
                    TourId = 3,
                    ServiceId = 2
                },
                new TourService()
                {
                    TourId = 3,
                    ServiceId = 3
                },
                new TourService()
                {
                    TourId = 3,
                    ServiceId = 4
                },
                new TourService()
                {
                    TourId = 3,
                    ServiceId = 5
                },
                new TourService()
                {
                    TourId = 4,
                    ServiceId = 1
                },
                new TourService()
                {
                    TourId = 4,
                    ServiceId = 2
                },
                 new TourService()
                 {
                     TourId = 4,
                     ServiceId = 4
                 }
            );
        }
    }
}
