﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using TBU.eshop.web.Models.Infrastructure.Database;

namespace TBU.eshop.web.Migrations
{
    [DbContext(typeof(EshopDbContext))]
    [Migration("20220317094823_MySQL_1.0.0_initialization")]
    partial class MySQL_100_initialization
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 64)
                .HasAnnotation("ProductVersion", "5.0.15");

            modelBuilder.Entity("TBU.eshop.web.Models.Entities.CarouselItem", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("ImageAlt")
                        .HasMaxLength(50)
                        .HasColumnType("varchar(50)");

                    b.Property<string>("ImageSource")
                        .IsRequired()
                        .HasMaxLength(255)
                        .HasColumnType("varchar(255)");

                    b.HasKey("ID");

                    b.ToTable("CarouselItem");

                    b.HasData(
                        new
                        {
                            ID = 1,
                            ImageAlt = "First slide",
                            ImageSource = "/img/Information-Technology.jpg"
                        },
                        new
                        {
                            ID = 2,
                            ImageAlt = "Second slide",
                            ImageSource = "/img/Information-Technology-1.jpg"
                        },
                        new
                        {
                            ID = 3,
                            ImageAlt = "Third slide",
                            ImageSource = "/img/IT.jpeg"
                        },
                        new
                        {
                            ID = 4,
                            ImageAlt = "Fourth slide",
                            ImageSource = "/img/bits-e1611847851285-1440x810.jpeg"
                        });
                });
#pragma warning restore 612, 618
        }
    }
}
