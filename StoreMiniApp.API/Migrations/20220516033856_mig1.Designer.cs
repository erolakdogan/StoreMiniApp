﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using StoreMiniApp.API.Domain.Data;

#nullable disable

namespace StoreMiniApp.API.Migrations
{
    [DbContext(typeof(StoreMiniAppDbContext))]
    [Migration("20220516033856_mig1")]
    partial class mig1
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.5")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("StoreMiniApp.API.Domain.Entities.Model.Discounts", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<DateTime>("CreatedDate")
                        .HasColumnType("datetime2");

                    b.Property<bool>("IsRatePercentage")
                        .HasColumnType("bit");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(25)
                        .HasColumnType("nvarchar(25)");

                    b.Property<decimal>("Rate")
                        .HasColumnType("decimal(18,2)");

                    b.Property<int>("Type")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("Discounts");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            CreatedDate = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            IsRatePercentage = true,
                            Name = "Affiliate Discount",
                            Rate = 10m,
                            Type = 1
                        },
                        new
                        {
                            Id = 2,
                            CreatedDate = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            IsRatePercentage = true,
                            Name = "Employee Discount",
                            Rate = 30m,
                            Type = 2
                        },
                        new
                        {
                            Id = 3,
                            CreatedDate = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            IsRatePercentage = true,
                            Name = "Loyal Customer Discount",
                            Rate = 5m,
                            Type = 3
                        },
                        new
                        {
                            Id = 4,
                            CreatedDate = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            IsRatePercentage = false,
                            Name = "Price Discount",
                            Rate = 5m,
                            Type = 4
                        });
                });

            modelBuilder.Entity("StoreMiniApp.API.Domain.Entities.Model.Invoice", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<DateTime>("CreatedDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("InvoiceNumber")
                        .IsRequired()
                        .HasMaxLength(25)
                        .HasColumnType("nvarchar(25)");

                    b.Property<int>("OrderId")
                        .HasMaxLength(25)
                        .HasColumnType("int");

                    b.Property<decimal>("OrderTotal")
                        .HasColumnType("decimal(18,2)");

                    b.Property<decimal>("Total")
                        .HasColumnType("decimal(18,2)");

                    b.Property<int>("UserId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("Invoice");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            CreatedDate = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            InvoiceNumber = "BJK010",
                            OrderId = 1,
                            OrderTotal = 0m,
                            Total = 500m,
                            UserId = 1
                        },
                        new
                        {
                            Id = 2,
                            CreatedDate = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            InvoiceNumber = "BJK011",
                            OrderId = 2,
                            OrderTotal = 0m,
                            Total = 1500m,
                            UserId = 2
                        },
                        new
                        {
                            Id = 3,
                            CreatedDate = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            InvoiceNumber = "BJK012",
                            OrderId = 3,
                            OrderTotal = 0m,
                            Total = 990m,
                            UserId = 3
                        },
                        new
                        {
                            Id = 4,
                            CreatedDate = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            InvoiceNumber = "BJK013",
                            OrderId = 4,
                            OrderTotal = 0m,
                            Total = 920m,
                            UserId = 4
                        });
                });

            modelBuilder.Entity("StoreMiniApp.API.Domain.Entities.Model.InvoiceDetails", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<DateTime>("CreatedDate")
                        .HasColumnType("datetime2");

                    b.Property<decimal>("DerivedProductCost")
                        .HasColumnType("decimal(18,2)");

                    b.Property<decimal>("DiscountPrice")
                        .HasColumnType("decimal(18,2)");

                    b.Property<int>("InvoiceId")
                        .HasColumnType("int");

                    b.Property<int>("ProductId")
                        .HasColumnType("int");

                    b.Property<string>("ProductName")
                        .IsRequired()
                        .HasMaxLength(30)
                        .HasColumnType("nvarchar(30)");

                    b.Property<decimal>("ProductPrice")
                        .HasColumnType("decimal(18,2)");

                    b.Property<int>("ProductQuantity")
                        .HasColumnType("int");

                    b.Property<decimal>("TotalDerivedCost")
                        .HasColumnType("decimal(18,2)");

                    b.HasKey("Id");

                    b.ToTable("InvoiceDetails");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            CreatedDate = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            DerivedProductCost = 40m,
                            DiscountPrice = 2m,
                            InvoiceId = 1,
                            ProductId = 2,
                            ProductName = "Item 2",
                            ProductPrice = 20m,
                            ProductQuantity = 2,
                            TotalDerivedCost = 38m
                        },
                        new
                        {
                            Id = 2,
                            CreatedDate = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            DerivedProductCost = 482m,
                            DiscountPrice = 20m,
                            InvoiceId = 1,
                            ProductId = 4,
                            ProductName = "Item 4",
                            ProductPrice = 482m,
                            ProductQuantity = 1,
                            TotalDerivedCost = 462m
                        },
                        new
                        {
                            Id = 3,
                            CreatedDate = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            DerivedProductCost = 250m,
                            DiscountPrice = 0m,
                            InvoiceId = 2,
                            ProductId = 40,
                            ProductName = "Item 40",
                            ProductPrice = 50m,
                            ProductQuantity = 5,
                            TotalDerivedCost = 250m
                        },
                        new
                        {
                            Id = 4,
                            CreatedDate = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            DerivedProductCost = 250m,
                            DiscountPrice = 25m,
                            InvoiceId = 4,
                            ProductId = 3,
                            ProductName = "Item 3",
                            ProductPrice = 50m,
                            ProductQuantity = 5,
                            TotalDerivedCost = 225m
                        },
                        new
                        {
                            Id = 5,
                            CreatedDate = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            DerivedProductCost = 400m,
                            DiscountPrice = 20m,
                            InvoiceId = 3,
                            ProductId = 5,
                            ProductName = "Item 5",
                            ProductPrice = 400m,
                            ProductQuantity = 1,
                            TotalDerivedCost = 380m
                        },
                        new
                        {
                            Id = 6,
                            CreatedDate = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            DerivedProductCost = 385m,
                            DiscountPrice = 0m,
                            InvoiceId = 3,
                            ProductId = 15,
                            ProductName = "Item 15",
                            ProductPrice = 77m,
                            ProductQuantity = 5,
                            TotalDerivedCost = 385m
                        },
                        new
                        {
                            Id = 7,
                            CreatedDate = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            DerivedProductCost = 1000m,
                            DiscountPrice = 80m,
                            InvoiceId = 4,
                            ProductId = 105,
                            ProductName = "Item 105",
                            ProductPrice = 200m,
                            ProductQuantity = 5,
                            TotalDerivedCost = 920m
                        });
                });

            modelBuilder.Entity("StoreMiniApp.API.Domain.Entities.Model.Users", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("Address")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<DateTime>("CreatedDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasMaxLength(30)
                        .HasColumnType("nvarchar(30)");

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasMaxLength(25)
                        .HasColumnType("nvarchar(25)");

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasMaxLength(25)
                        .HasColumnType("nvarchar(25)");

                    b.Property<string>("PhoneNumber")
                        .IsRequired()
                        .HasMaxLength(13)
                        .HasColumnType("nvarchar(13)");

                    b.Property<int>("UserType")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("Users");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Address = "İstanbul",
                            CreatedDate = new DateTime(2021, 5, 16, 6, 38, 56, 334, DateTimeKind.Local).AddTicks(2660),
                            Email = "sergen@email.com",
                            FirstName = "Sergen ",
                            LastName = "Yalçın",
                            PhoneNumber = "123456789",
                            UserType = 1
                        },
                        new
                        {
                            Id = 2,
                            Address = "Samsun",
                            CreatedDate = new DateTime(2020, 5, 16, 6, 38, 56, 334, DateTimeKind.Local).AddTicks(2674),
                            Email = "ilhan@email.com",
                            FirstName = "İlhan ",
                            LastName = "Mansız",
                            PhoneNumber = "505542210",
                            UserType = 1
                        },
                        new
                        {
                            Id = 3,
                            Address = "Ankara",
                            CreatedDate = new DateTime(2019, 5, 16, 6, 38, 56, 334, DateTimeKind.Local).AddTicks(2677),
                            Email = "metin@email.com",
                            FirstName = "Metin ",
                            LastName = "Tekin",
                            PhoneNumber = "504425102",
                            UserType = 2
                        },
                        new
                        {
                            Id = 4,
                            Address = "İstanbul",
                            CreatedDate = new DateTime(2022, 2, 16, 6, 38, 56, 334, DateTimeKind.Local).AddTicks(2678),
                            Email = "ali@email.com",
                            FirstName = "Ali ",
                            LastName = "Gültekin",
                            PhoneNumber = "5057581801",
                            UserType = 3
                        },
                        new
                        {
                            Id = 5,
                            Address = "İstanbul",
                            CreatedDate = new DateTime(2019, 5, 16, 6, 38, 56, 334, DateTimeKind.Local).AddTicks(2682),
                            Email = "feyyaz@email.com",
                            FirstName = "Feyyaz ",
                            LastName = "Uçar",
                            PhoneNumber = "5064581806",
                            UserType = 2
                        });
                });
#pragma warning restore 612, 618
        }
    }
}
