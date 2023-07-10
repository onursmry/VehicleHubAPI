﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using VehicleHub.DataAccess.Concrete.EntityFramework;

#nullable disable

namespace VehicleHub.DataAccess.Migrations
{
    [DbContext(typeof(VehicleHubContext))]
    [Migration("20230707183911_InitialCreate")]
    partial class InitialCreate
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder.HasAnnotation("ProductVersion", "7.0.8");

            modelBuilder.Entity("VehicleHub.Entities.Concrete.Boat", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("TEXT");

                    b.Property<string>("Brand")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("Color")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("TEXT");

                    b.Property<string>("Model")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<DateTime?>("UpdatedAt")
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.ToTable("Boats");

                    b.HasData(
                        new
                        {
                            Id = new Guid("241e961a-dd02-4309-8b43-1b1c10cb3b32"),
                            Brand = "Boston Whaler",
                            Color = "Red",
                            CreatedAt = new DateTime(2023, 7, 7, 21, 39, 10, 994, DateTimeKind.Local).AddTicks(2516),
                            Model = "420 Outrage"
                        },
                        new
                        {
                            Id = new Guid("2ae4dd05-d57a-4929-9a9a-a3fe6cb5e61a"),
                            Brand = "Boston Whaler",
                            Color = "Blue",
                            CreatedAt = new DateTime(2023, 7, 7, 21, 39, 10, 994, DateTimeKind.Local).AddTicks(2517),
                            Model = "405 Conquest"
                        },
                        new
                        {
                            Id = new Guid("c4538238-0e7b-420a-b326-31d54c845560"),
                            Brand = "Yamaha Boats",
                            Color = "Green",
                            CreatedAt = new DateTime(2023, 7, 7, 21, 39, 10, 994, DateTimeKind.Local).AddTicks(2519),
                            Model = "SX195"
                        },
                        new
                        {
                            Id = new Guid("a6603d9a-eee5-4a6c-882b-9c4c9064f904"),
                            Brand = "Yamaha Boats",
                            Color = "Teal",
                            CreatedAt = new DateTime(2023, 7, 7, 21, 39, 10, 994, DateTimeKind.Local).AddTicks(2520),
                            Model = "252 FSH"
                        },
                        new
                        {
                            Id = new Guid("3c49c549-c975-4f63-a43a-336ab6b0be48"),
                            Brand = "Beneteau",
                            Color = "Violet",
                            CreatedAt = new DateTime(2023, 7, 7, 21, 39, 10, 994, DateTimeKind.Local).AddTicks(2521),
                            Model = "Cyclades"
                        },
                        new
                        {
                            Id = new Guid("b211896b-7a66-4d61-85c7-c266cff480c4"),
                            Brand = "Beneteau",
                            Color = "Ivory",
                            CreatedAt = new DateTime(2023, 7, 7, 21, 39, 10, 994, DateTimeKind.Local).AddTicks(2522),
                            Model = "Antares"
                        },
                        new
                        {
                            Id = new Guid("2faec214-5c98-4266-9fb8-ef58da81d633"),
                            Brand = "Horizon",
                            Color = "Cyan",
                            CreatedAt = new DateTime(2023, 7, 7, 21, 39, 10, 994, DateTimeKind.Local).AddTicks(2523),
                            Model = "EP150"
                        },
                        new
                        {
                            Id = new Guid("452757d2-f263-4af1-b072-d6d0edeb6717"),
                            Brand = "Horizon",
                            Color = "Olive Green",
                            CreatedAt = new DateTime(2023, 7, 7, 21, 39, 10, 994, DateTimeKind.Local).AddTicks(2525),
                            Model = "RP110"
                        },
                        new
                        {
                            Id = new Guid("2b38f90c-6ec0-47f3-bbf4-d038d3d2ba06"),
                            Brand = "Silent",
                            Color = "Brown",
                            CreatedAt = new DateTime(2023, 7, 7, 21, 39, 10, 994, DateTimeKind.Local).AddTicks(2527),
                            Model = "80"
                        },
                        new
                        {
                            Id = new Guid("dedae488-ec42-47d7-b40c-f8f8026b35fb"),
                            Brand = "Silent",
                            Color = "Black",
                            CreatedAt = new DateTime(2023, 7, 7, 21, 39, 10, 994, DateTimeKind.Local).AddTicks(2529),
                            Model = "S64"
                        });
                });

            modelBuilder.Entity("VehicleHub.Entities.Concrete.Bus", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("TEXT");

                    b.Property<string>("Brand")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("Color")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("TEXT");

                    b.Property<string>("Model")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<DateTime?>("UpdatedAt")
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.ToTable("Buses");

                    b.HasData(
                        new
                        {
                            Id = new Guid("390ed370-ebf7-4563-81a3-04bec241dd88"),
                            Brand = "Volvo",
                            Color = "Red",
                            CreatedAt = new DateTime(2023, 7, 7, 21, 39, 10, 994, DateTimeKind.Local).AddTicks(2481),
                            Model = "9700"
                        },
                        new
                        {
                            Id = new Guid("316b2f9b-23b4-47d8-8d9e-5d80db34c39d"),
                            Brand = "MAN",
                            Color = "Blue",
                            CreatedAt = new DateTime(2023, 7, 7, 21, 39, 10, 994, DateTimeKind.Local).AddTicks(2483),
                            Model = "City 10"
                        },
                        new
                        {
                            Id = new Guid("8dae8515-f9d2-4a0a-99d6-802e5dc32b24"),
                            Brand = "Daimler",
                            Color = "Green",
                            CreatedAt = new DateTime(2023, 7, 7, 21, 39, 10, 994, DateTimeKind.Local).AddTicks(2486),
                            Model = "eCitaro"
                        },
                        new
                        {
                            Id = new Guid("1f73b9f7-1ccf-4ad8-9fd4-65d8249e4676"),
                            Brand = "Daimler",
                            Color = "Yellow",
                            CreatedAt = new DateTime(2023, 7, 7, 21, 39, 10, 994, DateTimeKind.Local).AddTicks(2488),
                            Model = "Tourismo"
                        },
                        new
                        {
                            Id = new Guid("a4c64e69-05a5-4867-aafa-42bd910d266c"),
                            Brand = "MAN",
                            Color = "Orange",
                            CreatedAt = new DateTime(2023, 7, 7, 21, 39, 10, 994, DateTimeKind.Local).AddTicks(2490),
                            Model = "City 12"
                        },
                        new
                        {
                            Id = new Guid("57a6a385-452b-40dc-9c1a-c5586eba5de5"),
                            Brand = "Yutong",
                            Color = "Purple",
                            CreatedAt = new DateTime(2023, 7, 7, 21, 39, 10, 994, DateTimeKind.Local).AddTicks(2493),
                            Model = "TC12"
                        },
                        new
                        {
                            Id = new Guid("d948da10-a6c1-4525-b188-c32932659631"),
                            Brand = "Volvo",
                            Color = "Black",
                            CreatedAt = new DateTime(2023, 7, 7, 21, 39, 10, 994, DateTimeKind.Local).AddTicks(2496),
                            Model = "9900"
                        },
                        new
                        {
                            Id = new Guid("46b65631-dac1-4d61-8b1b-6a7d002a3d7e"),
                            Brand = "Scania",
                            Color = "Gray",
                            CreatedAt = new DateTime(2023, 7, 7, 21, 39, 10, 994, DateTimeKind.Local).AddTicks(2497),
                            Model = "K230UB"
                        },
                        new
                        {
                            Id = new Guid("e2440af9-109e-4b8f-a2dc-a9eb461e0c77"),
                            Brand = "Scania",
                            Color = "Burgundy",
                            CreatedAt = new DateTime(2023, 7, 7, 21, 39, 10, 994, DateTimeKind.Local).AddTicks(2500),
                            Model = "Interlink"
                        },
                        new
                        {
                            Id = new Guid("ed6ba202-49c7-4d57-9689-6da91066afab"),
                            Brand = "Yutong",
                            Color = "White",
                            CreatedAt = new DateTime(2023, 7, 7, 21, 39, 10, 994, DateTimeKind.Local).AddTicks(2502),
                            Model = "GT12"
                        });
                });

            modelBuilder.Entity("VehicleHub.Entities.Concrete.Car", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("TEXT");

                    b.Property<string>("Brand")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("Color")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("TEXT");

                    b.Property<bool>("Headlights")
                        .HasColumnType("INTEGER");

                    b.Property<string>("Model")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<DateTime?>("UpdatedAt")
                        .HasColumnType("TEXT");

                    b.Property<int>("Wheels")
                        .HasColumnType("INTEGER");

                    b.HasKey("Id");

                    b.ToTable("Cars");

                    b.HasData(
                        new
                        {
                            Id = new Guid("9351859b-8491-497c-9c07-72485a8bd949"),
                            Brand = "Toyota",
                            Color = "Red",
                            CreatedAt = new DateTime(2023, 7, 7, 21, 39, 10, 994, DateTimeKind.Local).AddTicks(2324),
                            Headlights = true,
                            Model = "Corolla",
                            Wheels = 4
                        },
                        new
                        {
                            Id = new Guid("21233118-143c-46f5-ba23-24f837ad153a"),
                            Brand = "Ford",
                            Color = "Blue",
                            CreatedAt = new DateTime(2023, 7, 7, 21, 39, 10, 994, DateTimeKind.Local).AddTicks(2334),
                            Headlights = false,
                            Model = "Mustang",
                            Wheels = 4
                        },
                        new
                        {
                            Id = new Guid("0ed353d7-a4f2-4285-b571-de43bd22413d"),
                            Brand = "BMW",
                            Color = "Black",
                            CreatedAt = new DateTime(2023, 7, 7, 21, 39, 10, 994, DateTimeKind.Local).AddTicks(2337),
                            Headlights = true,
                            Model = "X5",
                            Wheels = 4
                        },
                        new
                        {
                            Id = new Guid("a5c5bb9d-e0c9-4494-b681-c97f3ac5affb"),
                            Brand = "Honda",
                            Color = "Silver",
                            CreatedAt = new DateTime(2023, 7, 7, 21, 39, 10, 994, DateTimeKind.Local).AddTicks(2339),
                            Headlights = false,
                            Model = "Civic",
                            Wheels = 4
                        },
                        new
                        {
                            Id = new Guid("59b9c480-59f1-4949-8e4f-9391f0feba37"),
                            Brand = "Mercedes-Benz",
                            Color = "White",
                            CreatedAt = new DateTime(2023, 7, 7, 21, 39, 10, 994, DateTimeKind.Local).AddTicks(2348),
                            Headlights = true,
                            Model = "E-Class",
                            Wheels = 4
                        },
                        new
                        {
                            Id = new Guid("29af5dd2-4a1d-4414-9526-ed8f1551efa6"),
                            Brand = "Audi",
                            Color = "Silver",
                            CreatedAt = new DateTime(2023, 7, 7, 21, 39, 10, 994, DateTimeKind.Local).AddTicks(2350),
                            Headlights = true,
                            Model = "A4",
                            Wheels = 4
                        },
                        new
                        {
                            Id = new Guid("56f6649f-da11-4d3a-818d-b9f78ee08e56"),
                            Brand = "Volkswagen",
                            Color = "Black",
                            CreatedAt = new DateTime(2023, 7, 7, 21, 39, 10, 994, DateTimeKind.Local).AddTicks(2353),
                            Headlights = false,
                            Model = "Golf",
                            Wheels = 4
                        },
                        new
                        {
                            Id = new Guid("bf9a64ca-bdb2-4cfc-a29d-035e98d18b07"),
                            Brand = "Chevrolet",
                            Color = "Yellow",
                            CreatedAt = new DateTime(2023, 7, 7, 21, 39, 10, 994, DateTimeKind.Local).AddTicks(2355),
                            Headlights = true,
                            Model = "Camaro",
                            Wheels = 4
                        },
                        new
                        {
                            Id = new Guid("18149c8e-a5f1-418b-893c-743b378a60f6"),
                            Brand = "Nissan",
                            Color = "Blue",
                            CreatedAt = new DateTime(2023, 7, 7, 21, 39, 10, 994, DateTimeKind.Local).AddTicks(2357),
                            Headlights = false,
                            Model = "Altima",
                            Wheels = 4
                        },
                        new
                        {
                            Id = new Guid("9482a17b-1a0e-4403-baa0-78751233e921"),
                            Brand = "Hyundai",
                            Color = "Red",
                            CreatedAt = new DateTime(2023, 7, 7, 21, 39, 10, 994, DateTimeKind.Local).AddTicks(2358),
                            Headlights = true,
                            Model = "Elantra",
                            Wheels = 4
                        });
                });
#pragma warning restore 612, 618
        }
    }
}
