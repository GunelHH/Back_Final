using System;
using System.Linq;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using OnlineShop.Models;

namespace OnlineShop.DAL
{
    public class AppDbContext:IdentityDbContext<AppUser>
    {
        public AppDbContext(DbContextOptions<AppDbContext>options):base(options)
        {
        }
        public DbSet<Clothe> Clothes { get; set; }

        public DbSet<Category> Categories { get; set; }

        public DbSet<ClotheInformation> ClotheInformation { get; set; }

        public DbSet<ImageClothe> ImageClothes { get; set; }

        public DbSet<Tag> Tags { get; set; }

        public DbSet<Slider> Sliders { get; set; }

        public DbSet<Size> Sizes { get; set; }

        public DbSet<Color> Colors { get; set; }

        public DbSet<Setting> Settings { get; set; }

        public DbSet<Advertisement> Advertisements { get; set; }

        public DbSet<BasketItem> BasketItems { get; set; }

        public DbSet<Message> Messages { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            foreach (var item in modelBuilder.Model.GetEntityTypes()
                .SelectMany(e=>e.GetProperties()
                .Where(p=>p.ClrType==typeof(decimal) || p.ClrType==typeof(decimal?)))
                )
            {
                item.SetColumnType("decimal(6,2)");
            }

            modelBuilder.Entity<Setting>()
               .HasIndex(p => p.Key)
               .IsUnique();

            modelBuilder.Entity<Category>()
               .HasIndex(c => c.Name)
               .IsUnique();

            base.OnModelCreating(modelBuilder);
        }
    }
}

