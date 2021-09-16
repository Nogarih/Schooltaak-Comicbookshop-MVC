using Microsoft.EntityFrameworkCore;
using pe1.Webshop.Domain;
using pe1.Webshop.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace pe1.Webshop.Web.Data
{
    public class DataSeeder
    {

        public static void Seed(ModelBuilder modelBuilder)
        {
            // Create Categories
            modelBuilder.Entity<Category>().HasData(
                new Category { Id = 1, CategoryName = "Manga" },
                new Category { Id = 2, CategoryName = "Anime" },
                new Category { Id = 3, CategoryName = "Figurines" },
                new Category { Id = 4, CategoryName = "US Comics" });

            // Create Infos

            modelBuilder.Entity<Info>().HasData(
                new Info { Id = 1, InfoText = "New 2021" },
                new Info { Id = 2, InfoText = "Limited Edition" },
                new Info { Id = 3, InfoText = "Pre-Order" },
                new Info { Id = 4, InfoText = "Collectible" },
                new Info { Id = 5, InfoText = "Finished" },
                new Info { Id = 6, InfoText = "Ongoing" },
                new Info { Id = 7, InfoText = "Upcomming" },
                new Info { Id = 8, InfoText = "Shonen" },
                new Info { Id = 9, InfoText = "Shoujo" },
                new Info { Id = 10, InfoText = "Slice of life" },
                new Info { Id = 11, InfoText = "Action" },
                new Info { Id = 12, InfoText = "Horror" },
                new Info { Id = 13, InfoText = "Romance" },
                new Info { Id = 14, InfoText = "School" },
                new Info { Id = 15, InfoText = "Adventure" },
                new Info { Id = 16, InfoText = "Fantasy" },
                new Info { Id = 17, InfoText = "Magic" });

            // Create Publishers
            modelBuilder.Entity<Publisher>().HasData(
                new Publisher { Id = 1, Name = "Kodansha comics" },
                new Publisher { Id = 2, Name = "Takara" },
                new Publisher { Id = 3, Name = "Viz Comics" });

            // Create Series
            modelBuilder.Entity<Serie>().HasData(
                new Serie { Id = 1, SerieName = "Attack on Titan" },
                new Serie { Id = 2, SerieName = "My Hero Academia" },
                new Serie { Id = 3, SerieName = "Castlevania" },
                new Serie { Id = 4, SerieName = "Star Wars" },
                new Serie { Id = 5, SerieName = "Marvel" });

            // Create Products
            modelBuilder.Entity<Product>().HasData(

                new
                {
                    Id = 1,
                    ProductName = "Attack on Titan Vol 01",
                    CategoryId = 1,
                    PublisherId = 1,
                    SerieId = 1,
                    Image = "attack-on-titan-vol-01.jpg",
                    Price = 11.95M
                },

                 new
                 {
                     Id = 2,
                     ProductName = "Shoto Todoroki PVC Figure",
                     CategoryId = 3,
                     PublisherId = 2,
                     SerieId = 2,
                     Image = "shoto-todoroki-statue-1.jpg",
                     Price = 43M
                 },

                 new
                 {
                     Id = 3,
                     ProductName = "My Hero Academia Vol 28",
                     CategoryId = 1,
                     PublisherId = 2,
                     SerieId = 2,
                     Image = "MHA-28-manga.jpg",
                     Price = 9.99M
                 },

                 new
                 {
                     Id = 4,
                     ProductName = "Attack on Titan SE01 DVD",
                     CategoryId = 2,
                     PublisherId = 1,
                     SerieId = 1,
                     Image = "AOTSE1.jpg",
                     Price = 30.99M
                 },

                 new
                 {
                     Id = 5,
                     ProductName = "Attack on Titan SE02 DVD",
                     CategoryId = 2,
                     PublisherId = 1,
                     SerieId = 1,
                     Image = "AOTSE2.jpg",
                     Price = 24.95M
                 },

                 new
                 {
                     Id = 6,
                     ProductName = "Dabi PVC figure",
                     CategoryId = 3,
                     PublisherId = 2,
                     SerieId = 2,
                     Image = "MHA-Dabi.jpg",
                     Price = 59M
                 },

                 new
                 {
                     Id = 7,
                     ProductName = "Darth Vader statue",
                     CategoryId = 3,
                     PublisherId = 3,
                     SerieId = 4,
                     Image = "SWFigure.jpg",
                     Price = 285M
                 },

                 new
                 {
                     Id = 8,
                     ProductName = "Star Wars Vol 38",
                     CategoryId = 4,
                     PublisherId = 3,
                     SerieId = 4,
                     Image = "SW-vol38.jpg",
                     Price = 19.85M
                 },

                 new
                 {
                     Id = 9,
                     ProductName = "Castlevania Season 03",
                     CategoryId = 2,
                     PublisherId = 3,
                     SerieId = 3,
                     Image = "castlevania-season-03-dvd.jpg",
                     Price = 27M
                 },

                 new
                 {
                     Id = 10,
                     ProductName = "My Hero Academia Season 2",
                     CategoryId = 2,
                     PublisherId = 2,
                     SerieId = 2,
                     Image = "mha_SE2_anime.jpg",
                     Price = 43.95M
                 },

                 new
                 {
                     Id = 11,
                     ProductName = "Star Wars Bounty Hunters",
                     CategoryId = 4,
                     PublisherId = 3,
                     SerieId = 4,
                     Image = "Star Wars Bounty.jpg",
                     Price = 16.99M
                 },

                 new
                 {
                     Id = 12,
                     ProductName = "My Hero Academia Vol 11",
                     CategoryId = 1,
                     PublisherId = 2,
                     SerieId = 2,
                     Image = "MHAVOL11.jpg",
                     Price = 6.75M
                 },

                 new
                 {
                     Id = 13,
                     ProductName = "Death of Wolverine",
                     CategoryId = 4,
                     PublisherId = 3,
                     SerieId = 5,
                     Image = "Wolverine.jpg",
                     Price = 17.99M
                 },

                 new
                 {
                     Id = 14,
                     ProductName = "Deadpool Vol 06",
                     CategoryId = 4,
                     PublisherId = 3,
                     SerieId = 5,
                     Image = "deadpool-6.jpg",
                     Price = 12M
                 }
                );

            // Create ProductInfos

            modelBuilder.Entity<ProductInfo>().HasData(

                // Product 1
                new ProductInfo
                {
                    ProductId = 1,
                    InfoId = 6
                },
                new ProductInfo
                {
                    ProductId = 1,
                    InfoId = 8
                },
                new ProductInfo
                {
                    ProductId = 1,
                    InfoId = 11
                },
                new ProductInfo
                {
                    ProductId = 1,
                    InfoId = 12
                },
                new ProductInfo
                {
                    ProductId = 1,
                    InfoId = 15
                },
                
                
                // Product 2

                new ProductInfo
                {
                    ProductId = 2,
                    InfoId = 1
                },
                new ProductInfo
                {
                    ProductId = 2,
                    InfoId = 4
                },
                new ProductInfo
                {
                    ProductId = 2,
                    InfoId = 11
                },
                new ProductInfo
                {
                    ProductId = 2,
                    InfoId = 14
                },
                new ProductInfo
                {
                    ProductId = 2,
                    InfoId = 8
                },

                // Product 3
                new ProductInfo
                {
                    ProductId = 3,
                    InfoId = 1
                },
                new ProductInfo
                {
                    ProductId = 3,
                    InfoId = 6
                },
                new ProductInfo
                {
                    ProductId = 3,
                    InfoId = 8
                },
                new ProductInfo
                {
                    ProductId = 3,
                    InfoId = 11
                },
                new ProductInfo
                {
                    ProductId = 3,
                    InfoId = 14
                },

                // Product 4
                new ProductInfo
                {
                    ProductId = 4,
                    InfoId = 2
                },
                new ProductInfo
                {
                    ProductId = 4,
                    InfoId = 5
                },
                new ProductInfo
                {
                    ProductId = 4,
                    InfoId = 8
                },
                new ProductInfo
                {
                    ProductId = 4,
                    InfoId = 11
                },
                new ProductInfo
                {
                    ProductId = 4,
                    InfoId = 12
                },
                new ProductInfo
                {
                    ProductId = 4,
                    InfoId = 15
                },
                new ProductInfo
                {
                    ProductId = 4,
                    InfoId = 16
                },

                // Product 5

                new ProductInfo
                {
                    ProductId = 5,
                    InfoId = 2
                },
                new ProductInfo
                {
                    ProductId = 5,
                    InfoId = 5
                },
                new ProductInfo
                {
                    ProductId = 5,
                    InfoId = 8
                },
                new ProductInfo
                {
                    ProductId = 5,
                    InfoId = 11
                },
                new ProductInfo
                {
                    ProductId = 5,
                    InfoId = 12
                },
                new ProductInfo
                {
                    ProductId = 5,
                    InfoId = 15
                },
                new ProductInfo
                {
                    ProductId = 5,
                    InfoId = 16
                },

                // Product 6

                new ProductInfo
                {
                    ProductId = 6,
                    InfoId = 3
                },
                new ProductInfo
                {
                    ProductId = 6,
                    InfoId = 8
                },

                new ProductInfo
                {
                    ProductId = 6,
                    InfoId = 13
                },

                new ProductInfo
                {
                    ProductId = 6,
                    InfoId = 14
                },

                new ProductInfo
                {
                    ProductId = 6,
                    InfoId = 17
                },

                // Product 7

                new ProductInfo
                {
                    ProductId = 7,
                    InfoId = 3
                },
                new ProductInfo
                {
                    ProductId = 7,
                    InfoId = 4
                },
                new ProductInfo
                {
                    ProductId = 7,
                    InfoId = 7
                },

                // Product 8

                new ProductInfo
                {
                    ProductId = 8,
                    InfoId = 5
                },
                new ProductInfo
                {
                    ProductId = 8,
                    InfoId = 11
                },
                new ProductInfo
                {
                    ProductId = 8,
                    InfoId = 12
                },
                new ProductInfo
                {
                    ProductId = 8,
                    InfoId = 16
                },
                new ProductInfo
                {
                    ProductId = 8,
                    InfoId = 17
                },

                // Product 9

                new ProductInfo
                {
                    ProductId = 9,
                    InfoId = 5
                },
                new ProductInfo
                {
                    ProductId = 9,
                    InfoId = 11
                },
                new ProductInfo
                {
                    ProductId = 9,
                    InfoId = 12
                },
                new ProductInfo
                {
                    ProductId = 9,
                    InfoId = 16
                },
                new ProductInfo
                {
                    ProductId = 9,
                    InfoId = 17
                },

                // Product 10

                new ProductInfo
                {
                    ProductId = 10,
                    InfoId = 1
                },
                new ProductInfo
                {
                    ProductId = 10,
                    InfoId = 6
                },
                new ProductInfo
                {
                    ProductId = 10,
                    InfoId = 8
                },
                new ProductInfo
                {
                    ProductId = 10,
                    InfoId = 11
                },
                new ProductInfo
                {
                    ProductId = 10,
                    InfoId = 14
                },
                new ProductInfo
                {
                    ProductId = 10,
                    InfoId = 17
                },

                // Product 11

                new ProductInfo
                {
                    ProductId = 11,
                    InfoId = 3
                },
                new ProductInfo
                {
                    ProductId = 11,
                    InfoId = 7
                },
                new ProductInfo
                {
                    ProductId = 11,
                    InfoId = 11
                },
                new ProductInfo
                {
                    ProductId = 11,
                    InfoId = 15
                },

                // Product 12

                new ProductInfo
                {
                    ProductId = 12,
                    InfoId = 1
                },
                new ProductInfo
                {
                    ProductId = 12,
                    InfoId = 6
                },
                new ProductInfo
                {
                    ProductId = 12,
                    InfoId = 8
                },
                new ProductInfo
                {
                    ProductId = 12,
                    InfoId = 11
                },
                new ProductInfo
                {
                    ProductId = 12,
                    InfoId = 14
                },

                // Product 13

                new ProductInfo
                {
                    ProductId = 13,
                    InfoId = 5
                },
                new ProductInfo
                {
                    ProductId = 13,
                    InfoId = 11
                },
                new ProductInfo
                {
                    ProductId = 13,
                    InfoId = 15
                },

                // Product 14

                new ProductInfo
                {
                    ProductId = 14,
                    InfoId = 5
                },
                new ProductInfo
                {
                    ProductId = 14,
                    InfoId = 11
                },
                new ProductInfo
                {
                    ProductId = 14,
                    InfoId = 15
                }); 
        }
    }
}
