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
    public class RequiredCategoryEntityConfiguration : IEntityTypeConfiguration<RequiredCategoryTour>
    {
        public void Configure(EntityTypeBuilder<RequiredCategoryTour> builder)
        {
            builder.HasData(
                new RequiredCategoryTour() 
                {
                    TourId = 1,
                    RequiredCategoryId = 1
                },
                 new RequiredCategoryTour()
                 {
                     TourId = 1,
                     RequiredCategoryId = 2
                 },
                  new RequiredCategoryTour()
                  {
                      TourId = 1,
                      RequiredCategoryId = 5
                  },
                  new RequiredCategoryTour()
                  {
                      TourId = 2,
                      RequiredCategoryId = 1
                  },
                 new RequiredCategoryTour()
                 {
                     TourId = 2,
                     RequiredCategoryId = 2
                 },
                  new RequiredCategoryTour()
                  {
                      TourId = 2,
                      RequiredCategoryId = 5
                  },
                  new RequiredCategoryTour()
                  {
                      TourId = 3,
                      RequiredCategoryId = 1
                  },
                 new RequiredCategoryTour()
                 {
                     TourId = 3,
                     RequiredCategoryId = 2
                 },
                  new RequiredCategoryTour()
                  {
                      TourId = 3,
                      RequiredCategoryId = 5
                  },
                  new RequiredCategoryTour()
                  {
                      TourId = 4,
                      RequiredCategoryId = 5
                  },
                  new RequiredCategoryTour()
                  {
                      TourId = 4,
                      RequiredCategoryId = 7
                  }
                );
        }
    }
}
