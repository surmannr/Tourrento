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
    public class ServiceEntityConfiguration : IEntityTypeConfiguration<Service>
    {
        public void Configure(EntityTypeBuilder<Service> builder)
        {
            builder.HasData(
                new Service()
                {
                    Id = 1,
                    Name = "Idegenvezetés"
                },
                new Service()
                {
                    Id = 2,
                    Name = "Étkezés biztosítása"
                },
                new Service()
                {
                    Id = 3,
                    Name = "Alvás lehetőség"
                },
                new Service()
                {
                    Id = 4,
                    Name = "Orvosi ellátás"
                },
                new Service()
                {
                    Id = 5,
                    Name = "Szükséges eszközök biztosítása"
                }
           );
        }
    }
}
