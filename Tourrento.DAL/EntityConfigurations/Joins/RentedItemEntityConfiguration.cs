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
    public class RentedItemEntityConfiguration : IEntityTypeConfiguration<RentedItem>
    {
        public void Configure(EntityTypeBuilder<RentedItem> builder)
        {
            builder.HasData(
                new RentedItem() 
                {
                    ItemId = 2,
                    RentId = 1,
                    Price = 3000,
                    Quantity = 2
                },
                new RentedItem()
                {
                    ItemId = 4,
                    RentId = 2,
                    Price = 4500,
                    Quantity = 2
                },
                new RentedItem()
                {
                    ItemId = 6,
                    RentId = 3,
                    Price = 3500,
                    Quantity = 2
                },
                new RentedItem()
                {
                    ItemId = 9,
                    RentId = 3,
                    Price = 2400,
                    Quantity = 1
                },
                new RentedItem()
                {
                    ItemId = 7,
                    RentId = 4,
                    Price = 2000,
                    Quantity = 2
                }
                );
        }
    }
}
