using IdentityServer4.EntityFramework.Options;
using Microsoft.AspNetCore.ApiAuthorization.IdentityServer;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Options;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tourrento.DAL.Models;
using Tourrento.DAL.Models.JoinTables;

namespace Tourrento.DAL
{
    public class TourrentoDbContext : ApiAuthorizationDbContext<User>
    {
        public DbSet<Category> Categories { get; set; }
        public DbSet<Item> Items { get; set; }
        public DbSet<Post> Posts { get; set; }
        public DbSet<Rent> Rents { get; set; }
        public DbSet<Service> Services { get; set; }
        public DbSet<Tour> Tours { get; set; }

        public DbSet<ItemCart> ItemCarts { get; set; }
        public DbSet<ItemCategory> ItemCategories { get; set; }
        public DbSet<ParticipateTour> ParticipateTours { get; set; }
        public DbSet<RentedItem> RentedItems { get; set; }
        public DbSet<RequiredCategoryTour> RequiredCategoryTours { get; set; }
        public DbSet<TourService> TourServices { get; set; }

        public TourrentoDbContext(DbContextOptions options, IOptions<OperationalStoreOptions> operationalStoreOptions) : base(options, operationalStoreOptions)
        {
        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);

            builder.Entity<Tour>(entity => entity.OwnsOne(e => e.StartLocation));
            builder.Entity<Tour>(entity => entity.OwnsOne(e => e.FinalLocation));

            builder.Entity<ItemCart>()
                .HasKey(e => new { e.ItemId, e.UserId });
            builder.Entity<ItemCart>()
                .HasOne(e => e.Item)
                .WithMany(e => e.ItemCarts)
                .HasForeignKey(e => e.ItemId);
            builder.Entity<ItemCart>()
                .HasOne(e => e.User)
                .WithMany(e => e.ItemCarts)
                .HasForeignKey(e => e.UserId);

            builder.Entity<ItemCategory>()
                .HasKey(e => new { e.ItemId, e.CategoryId });
            builder.Entity<ItemCategory>()
                .HasOne(e => e.Item)
                .WithMany(e => e.ItemCategories)
                .HasForeignKey(e => e.ItemId);
            builder.Entity<ItemCategory>()
                .HasOne(e => e.Category)
                .WithMany(e => e.ItemCategories)
                .HasForeignKey(e => e.CategoryId);

            builder.Entity<ParticipateTour>()
                .HasKey(e => new { e.TourId, e.UserId });
            builder.Entity<ParticipateTour>()
                .HasOne(e => e.Tour)
                .WithMany(e => e.ParticipateTours)
                .HasForeignKey(e => e.TourId);
            builder.Entity<ParticipateTour>()
                .HasOne(e => e.User)
                .WithMany(e => e.ParticipateTours)
                .HasForeignKey(e => e.UserId);

            builder.Entity<RentedItem>()
                .HasKey(e => new { e.ItemId, e.RentId });
            builder.Entity<RentedItem>()
                .HasOne(e => e.Rent)
                .WithMany(e => e.RentedItems)
                .HasForeignKey(e => e.RentId);
            builder.Entity<RentedItem>()
                .HasOne(e => e.Item)
                .WithMany(e => e.RentedItems)
                .HasForeignKey(e => e.ItemId);

            builder.Entity<RequiredCategoryTour>()
                .HasKey(e => new { e.RequiredCategoryId, e.TourId });
            builder.Entity<RequiredCategoryTour>()
                .HasOne(e => e.Tour)
                .WithMany(e => e.RequiredCategoryTours)
                .HasForeignKey(e => e.TourId);
            builder.Entity<RequiredCategoryTour>()
                .HasOne(e => e.RequiredCategory)
                .WithMany(e => e.RequiredCategoryTours)
                .HasForeignKey(e => e.RequiredCategoryId);

            builder.Entity<TourService>()
                .HasKey(e => new { e.TourId, e.ServiceId });
            builder.Entity<TourService>()
                .HasOne(e => e.Tour)
                .WithMany(e => e.TourServices)
                .HasForeignKey(e => e.TourId);
            builder.Entity<TourService>()
                .HasOne(e => e.Service)
                .WithMany(e => e.TourServices)
                .HasForeignKey(e => e.ServiceId);
        }
    }
}
