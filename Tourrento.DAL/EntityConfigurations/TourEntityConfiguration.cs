using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tourrento.DAL.Models;
using Tourrento.Shared.Owned;

namespace Tourrento.DAL.EntityConfigurations
{
    public class TourEntityConfiguration : IEntityTypeConfiguration<Tour>
    {
        public void Configure(EntityTypeBuilder<Tour> builder)
        {
            builder.HasData(
                new Tour()
                {
                    Id = 1,
                    CreatorId = "seedone",
                    StartDate = DateTimeOffset.Now.AddDays(21),
                    EndDate = DateTimeOffset.Now.AddDays(22),
                    Name = "János-hegyi túra",
                    Price = 2000,
                    MaxNumberOfPeople = 18,
                    Description = "Gyere el velünk a legjobb János-hegyi túrára! Ajánlott védőfelszerelés, mert a túra során mászásra is sor kerülhet.",
                    ImageName = "tour1.jpg"
                }
            );

            builder.OwnsOne(e => e.StartLocation).HasData(new
            {
                Country = "Magyarország",
                City = "Budapest",
                Street = "Zugligeti út 110",
                ZipCode = 1121,
                TourId = 1
            });

            builder.OwnsOne(e => e.FinalLocation).HasData(new
            {
                Country = "Magyarország",
                City = "Budapest",
                Street = "Zugligeti út 110",
                ZipCode = 1121,
                TourId = 1
            });

            builder.HasData(
                new Tour()
                {
                    Id = 2,
                    CreatorId = "seedone",
                    StartDate = DateTimeOffset.Now.AddDays(33),
                    EndDate = DateTimeOffset.Now.AddDays(33),
                    Name = "Gellért-hegyi túra",
                    Price = 1800,
                    MaxNumberOfPeople = 30,
                    Description = "Gyere el velünk a legjobb Gellért-hegyi túrára! Ajánlott védőfelszerelés, mert a túra során mászásra is sor kerülhet.",
                    ImageName = "tour2.jpg"
                }
            );

            builder.OwnsOne(e => e.StartLocation).HasData(new
            {
                Country = "Magyarország",
                City = "Budapest",
                Street = "Szent Gellért rkp. 16",
                ZipCode = 1013,
                TourId = 2
            });

            builder.OwnsOne(e => e.FinalLocation).HasData(new
            {
                Country = "Magyarország",
                City = "Budapest",
                Street = "Szent Gellért rkp. 16",
                ZipCode = 1013,
                TourId = 2
            });

            builder.HasData(
               new Tour()
               {
                   Id = 3,
                   CreatorId = "seedone",
                   StartDate = DateTimeOffset.Now.AddDays(38),
                   EndDate = DateTimeOffset.Now.AddDays(48),
                   Name = "Több napos túra",
                   Price = 42800,
                   MaxNumberOfPeople = 32,
                   Description = "A több napos túra során rengeteg kalandban veszünk majd részt. Az étkezés és alvást a túra szervezői biztosítják.",
                   ImageName = "tour3.jpg"
               }
           );

            builder.OwnsOne(e => e.StartLocation).HasData(new
            {
                Country = "Magyarország",
                City = "Budaörs",
                Street = "Mandula utca",
                ZipCode = 2040,
                TourId = 3
            });

            builder.OwnsOne(e => e.FinalLocation).HasData(new
            {
                Country = "Magyarország",
                City = "Budapest",
                Street = "Glück Frigyes út",
                ZipCode = 1025,
                TourId = 3
            });

            builder.HasData(
               new Tour()
               {
                   Id = 4,
                   CreatorId = "seedone",
                   StartDate = DateTimeOffset.Now.AddDays(34),
                   EndDate = DateTimeOffset.Now.AddDays(34),
                   Name = "Hegyi biciklizés",
                   Price = 1800,
                   MaxNumberOfPeople = 12,
                   Description = "A biciklizés során a fő célunk, hogy mindenki jól érezze magát. A túra során a pihenőkön közös programokat szervezünk, hogy a csapatot jobban összekovácsoljuk.",
                   ImageName = "tour4.jpg"
               }
           );

            builder.OwnsOne(e => e.StartLocation).HasData(new
            {
                Country = "Magyarország",
                City = "Budapest",
                Street = "Mátyáshegyi út 57",
                ZipCode = 1037,
                TourId = 4
            });

            builder.OwnsOne(e => e.FinalLocation).HasData(new
            {
                Country = "Magyarország",
                City = "Budapest",
                Street = "Mátyáshegyi út 57",
                ZipCode = 1037,
                TourId = 4
            });
        }
    }
}
