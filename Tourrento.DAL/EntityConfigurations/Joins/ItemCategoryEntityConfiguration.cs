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
    public class ItemCategoryEntityConfiguration : IEntityTypeConfiguration<ItemCategory>
    {
        public void Configure(EntityTypeBuilder<ItemCategory> builder)
        {
            builder.HasData(
                new ItemCategory()
                { 
                    ItemId = 1,
                    CategoryId = 10
                },
                new ItemCategory()
                {
                    ItemId = 2,
                    CategoryId = 1
                },
                 new ItemCategory()
                 {
                     ItemId = 3,
                     CategoryId = 3
                 },
                 new ItemCategory()
                 {
                     ItemId = 4,
                     CategoryId = 7
                 },
                 new ItemCategory()
                 {
                     ItemId = 5,
                     CategoryId = 8
                 },
                 new ItemCategory()
                 {
                     ItemId = 6,
                     CategoryId = 5
                 },
                 new ItemCategory()
                 {
                     ItemId = 6,
                     CategoryId = 6
                 },
                  new ItemCategory()
                  {
                      ItemId = 7,
                      CategoryId = 2
                  },
                  new ItemCategory()
                  {
                      ItemId = 7,
                      CategoryId = 5
                  },
                   new ItemCategory()
                   {
                       ItemId = 8,
                       CategoryId = 5
                   },
                   new ItemCategory()
                   {
                       ItemId = 8,
                       CategoryId = 9
                   },
                   new ItemCategory()
                   {
                       ItemId = 9,
                       CategoryId = 7
                   },
                   new ItemCategory()
                   {
                       ItemId = 10,
                       CategoryId = 1
                   },
                    new ItemCategory()
                    {
                        ItemId = 10,
                        CategoryId = 4
                    }
                );
        }
    }
}
