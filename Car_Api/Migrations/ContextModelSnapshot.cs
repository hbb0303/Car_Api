﻿// <auto-generated />
using Car_Api.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace Car_Api.Migrations
{
    [DbContext(typeof(Context))]
    partial class ContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.25")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("Car_Api.Models.Brand", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("Country")
                        .HasMaxLength(20)
                        .HasColumnType("nvarchar(20)");

                    b.Property<string>("Description")
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(20)
                        .HasColumnType("nvarchar(20)");

                    b.HasKey("Id");

                    b.ToTable("Brands");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Country = "Sweden",
                            Description = "v60 is cool car",
                            Name = "Volvo"
                        },
                        new
                        {
                            Id = 2,
                            Country = "Germany",
                            Description = "530e is nice car",
                            Name = "Bmw"
                        },
                        new
                        {
                            Id = 3,
                            Country = "USA",
                            Description = "i have no idea about this one",
                            Name = "Tesla"
                        },
                        new
                        {
                            Id = 4,
                            Country = "Japan",
                            Description = "Reliable car, they say",
                            Name = "Toyoto"
                        },
                        new
                        {
                            Id = 5,
                            Country = "South Korea",
                            Description = "my favorite xceed",
                            Name = "Kia"
                        });
                });

            modelBuilder.Entity("Car_Api.Models.Car", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<int>("BrandId")
                        .HasColumnType("int");

                    b.Property<string>("Description")
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<bool>("IsElectric")
                        .HasColumnType("bit");

                    b.Property<string>("Model")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Year")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("BrandId");

                    b.ToTable("Cars");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            BrandId = 1,
                            Description = "Car of the year",
                            IsElectric = false,
                            Model = "V60",
                            Year = 2021
                        },
                        new
                        {
                            Id = 2,
                            BrandId = 2,
                            Description = "cool",
                            IsElectric = false,
                            Model = "530e",
                            Year = 2022
                        },
                        new
                        {
                            Id = 3,
                            BrandId = 3,
                            Description = "car car car",
                            IsElectric = true,
                            Model = "Model X",
                            Year = 2021
                        },
                        new
                        {
                            Id = 4,
                            BrandId = 3,
                            Description = "maybe maybe",
                            IsElectric = true,
                            Model = "Model 3",
                            Year = 2023
                        },
                        new
                        {
                            Id = 5,
                            BrandId = 4,
                            Description = "good one",
                            IsElectric = false,
                            Model = "Corolla Hybrid",
                            Year = 2020
                        },
                        new
                        {
                            Id = 6,
                            BrandId = 5,
                            Description = "crossover like car",
                            IsElectric = true,
                            Model = "xCeed",
                            Year = 2023
                        },
                        new
                        {
                            Id = 7,
                            BrandId = 5,
                            Description = "tractor",
                            IsElectric = false,
                            Model = "Sorento",
                            Year = 2011
                        },
                        new
                        {
                            Id = 8,
                            BrandId = 5,
                            Description = "not a car bicycle",
                            IsElectric = false,
                            Model = "Picanto",
                            Year = 2019
                        });
                });

            modelBuilder.Entity("Car_Api.Models.Car", b =>
                {
                    b.HasOne("Car_Api.Models.Brand", "Brand")
                        .WithMany("Cars")
                        .HasForeignKey("BrandId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Brand");
                });

            modelBuilder.Entity("Car_Api.Models.Brand", b =>
                {
                    b.Navigation("Cars");
                });
#pragma warning restore 612, 618
        }
    }
}
