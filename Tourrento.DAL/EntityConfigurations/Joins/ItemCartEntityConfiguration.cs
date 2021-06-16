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
    public class ItemCartEntityConfiguration : IEntityTypeConfiguration<ItemCart>
    {
        public void Configure(EntityTypeBuilder<ItemCart> builder)
        {
            builder.HasData(
                new ItemCart()
                {
                    ItemId = 1,
                    UserId = "seedtwo",
                    Quantity = 2
                },
                new ItemCart()
                {
                    ItemId = 5,
                    UserId = "seedtwo",
                    Quantity = 1
                },
                new ItemCart()
                {
                    ItemId = 3,
                    UserId = "seedtwo",
                    Quantity = 2
                },
                new ItemCart()
                {
                    ItemId = 8,
                    UserId = "seedtwo",
                    Quantity = 3
                }
            );

            builder.HasData(
                new ItemCart()
                {
                    ItemId = 2,
                    UserId = "seedthree",
                    Quantity = 3
                },
                new ItemCart()
                {
                    ItemId = 10,
                    UserId = "seedthree",
                    Quantity = 2
                },
                new ItemCart()
                {
                    ItemId = 9,
                    UserId = "seedthree",
                    Quantity = 2
                },
                new ItemCart()
                {
                    ItemId = 6,
                    UserId = "seedthree",
                    Quantity = 1
                }
            );
        }
    }
}
