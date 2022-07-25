﻿// <auto-generated />
using System;
using Infrastructure.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace Infrastructure.Data.Migrations
{
    [DbContext(typeof(AppDbContext))]
    partial class AppDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.6")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("ApplicationCore.Entities.Darkstore", b =>
                {
                    b.Property<int>("DarkstoreId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("DarkstoreId"), 1L, 1);

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("DarkstoreId");

                    b.ToTable("Darkstores");

                    b.HasData(
                        new
                        {
                            DarkstoreId = 1,
                            Name = "Brooklyn"
                        },
                        new
                        {
                            DarkstoreId = 2,
                            Name = "The Bronx"
                        },
                        new
                        {
                            DarkstoreId = 3,
                            Name = "Queens"
                        });
                });

            modelBuilder.Entity("ApplicationCore.Entities.Employee", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("AccountNumber")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("DarkstoreId")
                        .HasColumnType("int");

                    b.Property<string>("FirstName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("LastName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Position")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("DarkstoreId");

                    b.ToTable("Employees");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            AccountNumber = "00000001",
                            DarkstoreId = 1,
                            FirstName = "Homer",
                            LastName = "Simpson",
                            Position = "courier"
                        },
                        new
                        {
                            Id = 2,
                            AccountNumber = "00000002",
                            DarkstoreId = 1,
                            FirstName = "Marge",
                            LastName = "Simpson",
                            Position = "picker"
                        },
                        new
                        {
                            Id = 3,
                            AccountNumber = "00000003",
                            DarkstoreId = 1,
                            FirstName = "Bart",
                            LastName = "Simpson",
                            Position = "courier"
                        },
                        new
                        {
                            Id = 4,
                            AccountNumber = "00000004",
                            DarkstoreId = 2,
                            FirstName = "Philip",
                            LastName = "Fry",
                            Position = "courier"
                        },
                        new
                        {
                            Id = 5,
                            AccountNumber = "00000005",
                            DarkstoreId = 2,
                            FirstName = "Farnsworth",
                            LastName = "Professor",
                            Position = "courier"
                        },
                        new
                        {
                            Id = 6,
                            AccountNumber = "00000006",
                            DarkstoreId = 2,
                            FirstName = "Leela",
                            LastName = "Turanga",
                            Position = "picker"
                        },
                        new
                        {
                            Id = 7,
                            AccountNumber = "00000007",
                            DarkstoreId = 3,
                            FirstName = "Stan",
                            LastName = "Smith",
                            Position = "picker"
                        },
                        new
                        {
                            Id = 8,
                            AccountNumber = "00000008",
                            DarkstoreId = 3,
                            FirstName = "Steve",
                            LastName = "Smith",
                            Position = "courier"
                        },
                        new
                        {
                            Id = 9,
                            AccountNumber = "00000003",
                            DarkstoreId = 3,
                            FirstName = "Roger",
                            LastName = "Smith",
                            Position = "courier"
                        });
                });

            modelBuilder.Entity("ApplicationCore.Entities.Rate", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<decimal?>("RatePerHour")
                        .HasColumnType("decimal(18,2)");

                    b.HasKey("Id");

                    b.ToTable("Rates");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Name = "Picker",
                            RatePerHour = 10m
                        },
                        new
                        {
                            Id = 2,
                            Name = "Courier standart",
                            RatePerHour = 8m
                        },
                        new
                        {
                            Id = 3,
                            Name = "Courier in company car",
                            RatePerHour = 12m
                        },
                        new
                        {
                            Id = 4,
                            Name = "Courier in his car",
                            RatePerHour = 9.5m
                        });
                });

            modelBuilder.Entity("ApplicationCore.Entities.Employee", b =>
                {
                    b.HasOne("ApplicationCore.Entities.Darkstore", "Darkstore")
                        .WithMany("Employees")
                        .HasForeignKey("DarkstoreId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Darkstore");
                });

            modelBuilder.Entity("ApplicationCore.Entities.Darkstore", b =>
                {
                    b.Navigation("Employees");
                });
#pragma warning restore 612, 618
        }
    }
}
