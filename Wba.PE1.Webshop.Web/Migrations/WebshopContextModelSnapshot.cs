// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using pe1.Webshop.Web.Data;

namespace pe1.Webshop.Web.Migrations
{
    [DbContext(typeof(WebshopContext))]
    partial class WebshopContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
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

                    b.HasData(
                        new { Id = 1, InfoText = "New 2021" },
                        new { Id = 2, InfoText = "Limited Edition" },
                        new { Id = 3, InfoText = "Pre-Order" },
                        new { Id = 4, InfoText = "Collectible" },
                        new { Id = 5, InfoText = "Finished" },
                        new { Id = 6, InfoText = "Ongoing" },
                        new { Id = 7, InfoText = "Upcomming" },
                        new { Id = 8, InfoText = "Shonen" },
                        new { Id = 9, InfoText = "Shoujo" },
                        new { Id = 10, InfoText = "Slice of life" },
                        new { Id = 11, InfoText = "Action" },
                        new { Id = 12, InfoText = "Horror" },
                        new { Id = 13, InfoText = "Romance" },
                        new { Id = 14, InfoText = "School" },
                        new { Id = 15, InfoText = "Adventure" },
                        new { Id = 16, InfoText = "Fantasy" },
                        new { Id = 17, InfoText = "Magic" }
                    );
                });

            modelBuilder.Entity("pe1.Webshop.Domain.Entities.ProductInfo", b =>
                {
                    b.Property<int>("ProductId");

                    b.Property<int>("InfoId");

                    b.HasKey("ProductId", "InfoId");

                    b.HasIndex("InfoId");

                    b.ToTable("ProductInfos");

                    b.HasData(
                        new { ProductId = 1, InfoId = 6 },
                        new { ProductId = 1, InfoId = 8 },
                        new { ProductId = 1, InfoId = 11 },
                        new { ProductId = 1, InfoId = 12 },
                        new { ProductId = 1, InfoId = 15 },
                        new { ProductId = 2, InfoId = 1 },
                        new { ProductId = 2, InfoId = 4 },
                        new { ProductId = 2, InfoId = 11 },
                        new { ProductId = 2, InfoId = 14 },
                        new { ProductId = 2, InfoId = 8 },
                        new { ProductId = 3, InfoId = 1 },
                        new { ProductId = 3, InfoId = 6 },
                        new { ProductId = 3, InfoId = 8 },
                        new { ProductId = 3, InfoId = 11 },
                        new { ProductId = 3, InfoId = 14 },
                        new { ProductId = 4, InfoId = 2 },
                        new { ProductId = 4, InfoId = 5 },
                        new { ProductId = 4, InfoId = 8 },
                        new { ProductId = 4, InfoId = 11 },
                        new { ProductId = 4, InfoId = 12 },
                        new { ProductId = 4, InfoId = 15 },
                        new { ProductId = 4, InfoId = 16 },
                        new { ProductId = 5, InfoId = 2 },
                        new { ProductId = 5, InfoId = 5 },
                        new { ProductId = 5, InfoId = 8 },
                        new { ProductId = 5, InfoId = 11 },
                        new { ProductId = 5, InfoId = 12 },
                        new { ProductId = 5, InfoId = 15 },
                        new { ProductId = 5, InfoId = 16 },
                        new { ProductId = 6, InfoId = 3 },
                        new { ProductId = 6, InfoId = 8 },
                        new { ProductId = 6, InfoId = 13 },
                        new { ProductId = 6, InfoId = 14 },
                        new { ProductId = 6, InfoId = 17 },
                        new { ProductId = 7, InfoId = 3 },
                        new { ProductId = 7, InfoId = 4 },
                        new { ProductId = 7, InfoId = 7 },
                        new { ProductId = 8, InfoId = 5 },
                        new { ProductId = 8, InfoId = 11 },
                        new { ProductId = 8, InfoId = 12 },
                        new { ProductId = 8, InfoId = 16 },
                        new { ProductId = 8, InfoId = 17 },
                        new { ProductId = 9, InfoId = 5 },
                        new { ProductId = 9, InfoId = 11 },
                        new { ProductId = 9, InfoId = 12 },
                        new { ProductId = 9, InfoId = 16 },
                        new { ProductId = 9, InfoId = 17 },
                        new { ProductId = 10, InfoId = 1 },
                        new { ProductId = 10, InfoId = 6 },
                        new { ProductId = 10, InfoId = 8 },
                        new { ProductId = 10, InfoId = 11 },
                        new { ProductId = 10, InfoId = 14 },
                        new { ProductId = 10, InfoId = 17 },
                        new { ProductId = 11, InfoId = 3 },
                        new { ProductId = 11, InfoId = 7 },
                        new { ProductId = 11, InfoId = 11 },
                        new { ProductId = 11, InfoId = 15 },
                        new { ProductId = 12, InfoId = 1 },
                        new { ProductId = 12, InfoId = 6 },
                        new { ProductId = 12, InfoId = 8 },
                        new { ProductId = 12, InfoId = 11 },
                        new { ProductId = 12, InfoId = 14 },
                        new { ProductId = 13, InfoId = 5 },
                        new { ProductId = 13, InfoId = 11 },
                        new { ProductId = 13, InfoId = 15 },
                        new { ProductId = 14, InfoId = 5 },
                        new { ProductId = 14, InfoId = 11 },
                        new { ProductId = 14, InfoId = 15 }
                    );
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

                    b.HasData(
                        new { Id = 1, CategoryId = 1, Image = "attack-on-titan-vol-01.jpg", Price = 11.95m, ProductName = "Attack on Titan Vol 01", PublisherId = 1, SerieId = 1 },
                        new { Id = 2, CategoryId = 3, Image = "shoto-todoroki-statue-1.jpg", Price = 43m, ProductName = "Shoto Todoroki PVC Figure", PublisherId = 2, SerieId = 2 },
                        new { Id = 3, CategoryId = 1, Image = "MHA-28-manga.jpg", Price = 9.99m, ProductName = "My Hero Academia Vol 28", PublisherId = 2, SerieId = 2 },
                        new { Id = 4, CategoryId = 2, Image = "AOTSE1.jpg", Price = 30.99m, ProductName = "Attack on Titan SE01 DVD", PublisherId = 1, SerieId = 1 },
                        new { Id = 5, CategoryId = 2, Image = "AOTSE2.jpg", Price = 24.95m, ProductName = "Attack on Titan SE02 DVD", PublisherId = 1, SerieId = 1 },
                        new { Id = 6, CategoryId = 3, Image = "MHA-Dabi.jpg", Price = 59m, ProductName = "Dabi PVC figure", PublisherId = 2, SerieId = 2 },
                        new { Id = 7, CategoryId = 3, Image = "SWFigure.jpg", Price = 285m, ProductName = "Darth Vader statue", PublisherId = 3, SerieId = 4 },
                        new { Id = 8, CategoryId = 4, Image = "SW-vol38.jpg", Price = 19.85m, ProductName = "Star Wars Vol 38", PublisherId = 3, SerieId = 4 },
                        new { Id = 9, CategoryId = 2, Image = "castlevania-season-03-dvd.jpg", Price = 27m, ProductName = "Castlevania Season 03", PublisherId = 3, SerieId = 3 },
                        new { Id = 10, CategoryId = 2, Image = "mha_SE2_anime.jpg", Price = 43.95m, ProductName = "My Hero Academia Season 2", PublisherId = 2, SerieId = 2 },
                        new { Id = 11, CategoryId = 4, Image = "Star Wars Bounty.jpg", Price = 16.99m, ProductName = "Star Wars Bounty Hunters", PublisherId = 3, SerieId = 4 },
                        new { Id = 12, CategoryId = 1, Image = "MHAVOL11.jpg", Price = 6.75m, ProductName = "My Hero Academia Vol 11", PublisherId = 2, SerieId = 2 },
                        new { Id = 13, CategoryId = 4, Image = "Wolverine.jpg", Price = 17.99m, ProductName = "Death of Wolverine", PublisherId = 3, SerieId = 5 },
                        new { Id = 14, CategoryId = 4, Image = "deadpool-6.jpg", Price = 12m, ProductName = "Deadpool Vol 06", PublisherId = 3, SerieId = 5 }
                    );
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

                    b.HasData(
                        new { Id = 1, Name = "Kodansha comics" },
                        new { Id = 2, Name = "Takara" },
                        new { Id = 3, Name = "Viz Comics" }
                    );
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

                    b.HasData(
                        new { Id = 1, SerieName = "Attack on Titan" },
                        new { Id = 2, SerieName = "My Hero Academia" },
                        new { Id = 3, SerieName = "Castlevania" },
                        new { Id = 4, SerieName = "Star Wars" },
                        new { Id = 5, SerieName = "Marvel" }
                    );
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
