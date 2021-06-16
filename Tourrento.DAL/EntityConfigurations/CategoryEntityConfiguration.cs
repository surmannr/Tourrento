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
    public class CategoryEntityConfiguration : IEntityTypeConfiguration<Category>
    {
        public void Configure(EntityTypeBuilder<Category> builder)
        {
            builder.HasData(
                new Category()
                {
                    Id = 1,
                    Name = "Védőfelszerelés",
                    ParentCategoryId = null
                },
                new Category()
                {
                    Id = 2,
                    Name = "Mászófelszerelés",
                    ParentCategoryId = null
                },
                new Category()
                {
                    Id = 3,
                    Name = "Ejtőernyő",
                    ParentCategoryId = null
                },
                new Category()
                {
                    Id = 4,
                    Name = "Búvárruha",
                    ParentCategoryId = 1
                },
                new Category()
                {
                    Id = 5,
                    Name = "Túrafelszerelés",
                    ParentCategoryId = null
                },
                new Category()
                {
                    Id = 6,
                    Name = "Sétabot",
                    ParentCategoryId = 5
                },
                new Category()
                {
                    Id = 7,
                    Name = "Bicikli",
                    ParentCategoryId = null
                },
                new Category()
                {
                    Id = 8,
                    Name = "Görkorcsolya",
                    ParentCategoryId = null
                },
                new Category()
                {
                    Id = 9,
                    Name = "Egyéb felszerelés",
                    ParentCategoryId = null
                },
                new Category()
                {
                    Id = 10,
                    Name = "Tandem",
                    ParentCategoryId = 7
                }
            );
        }
    }
}
