﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using pe1.Webshop.Web.Data;

namespace pe1.Webshop.Web.Migrations
{
    [DbContext(typeof(WebshopContext))]
    [Migration("20210426073126_SeedDataCategories")]
    partial class SeedDataCategories
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.1.14-servicing-32113")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("pe1.Webshop.Domain.Category", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("CategoryName")
                        .HasMaxLength(50);

                    b.HasKey("Id");

                    b.ToTable("Categories");

                    b.HasData(
                        new { Id = 1, CategoryName = "Manga" },
                        new { Id = 2, CategoryName = "Anime" },
                        new { Id = 3, CategoryName = "Figurines" },
                        new { Id = 4, CategoryName = "US Comics" }
                    );
                });

            modelBuilder.Entity("pe1.Webshop.Domain.Entities.Info", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("InfoText")
                        .HasMaxLength(50);

                    b.HasKey("Id");

                    b.ToTable("Infos");
                });

            modelBuilder.Entity("pe1.Webshop.Domain.Entities.ProductInfo", b =>
                {
                    b.Property<int>("ProductId");

                    b.Property<int>("InfoId");

                    b.HasKey("ProductId", "InfoId");

                    b.HasIndex("InfoId");

                    b.ToTable("ProductInfos");
                });

            modelBuilder.Entity("pe1.Webshop.Domain.Product", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("CategoryId");

                    b.Property<string>("Image")
                        .IsRequired();

                    b.Property<decimal>("Price");

                    b.Property<string>("ProductName")
                        .IsRequired()
                        .HasMaxLength(150);

                    b.Property<int>("PublisherId");

                    b.Property<int>("SerieId");

                    b.HasKey("Id");

                    b.HasIndex("CategoryId");

                    b.HasIndex("PublisherId");

                    b.HasIndex("SerieId");

                    b.ToTable("Products");
                });

            modelBuilder.Entity("pe1.Webshop.Domain.Publisher", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(150);

                    b.HasKey("Id");

                    b.ToTable("Publishers");
                });

            modelBuilder.Entity("pe1.Webshop.Domain.Serie", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("SerieName")
                        .IsRequired()
                        .HasMaxLength(150);

                    b.HasKey("Id");

                    b.ToTable("Series");
                });

            modelBuilder.Entity("pe1.Webshop.Domain.Entities.ProductInfo", b =>
                {
                    b.HasOne("pe1.Webshop.Domain.Entities.Info", "Info")
                        .WithMany("ProductInfos")
                        .HasForeignKey("InfoId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("pe1.Webshop.Domain.Product", "Product")
                        .WithMany("ProductInfos")
                        .HasForeignKey("ProductId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("pe1.Webshop.Domain.Product", b =>
                {
                    b.HasOne("pe1.Webshop.Domain.Category", "Category")
                        .WithMany()
                        .HasForeignKey("CategoryId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("pe1.Webshop.Domain.Publisher", "Publisher")
                        .WithMany()
                        .HasForeignKey("PublisherId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("pe1.Webshop.Domain.Serie", "Serie")
                        .WithMany()
                        .HasForeignKey("SerieId")
                        .OnDelete(DeleteBehavior.Cascade);
                });
#pragma warning restore 612, 618
        }
    }
}
