using Microsoft.EntityFrameworkCore;
using pe1.Webshop.Domain;
using pe1.Webshop.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace pe1.Webshop.Web.Data
{
    public class WebshopContext : DbContext
    {
        public WebshopContext(DbContextOptions<WebshopContext> options) : base(options)
        {

        }

        public DbSet<Category> Categories { get; set; }
        public DbSet<Info> Infos { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<Publisher> Publishers { get; set; }
        public DbSet<Serie> Series { get; set; }
        public DbSet<ProductInfo> ProductInfos { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            //ProductInfo 
            modelBuilder.Entity<ProductInfo>()
                .ToTable("ProductInfos")
                .HasKey(pi => new { pi.ProductId, pi.InfoId });

            modelBuilder.Entity<ProductInfo>()
                .HasOne(pi => pi.Product)
                .WithMany(pi => pi.ProductInfos)
                .HasForeignKey(pi => pi.ProductId);

            modelBuilder.Entity<ProductInfo>()
            .HasOne(pi => pi.Info)
            .WithMany(pi => pi.ProductInfos)
            .HasForeignKey(pi => pi.InfoId);


            DataSeeder.Seed(modelBuilder);
            base.OnModelCreating(modelBuilder);

        }
    }
}
