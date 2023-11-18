﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using WebApp.Context;

#nullable disable

namespace WebApp.Migrations
{
    [DbContext(typeof(PersonContext))]
    [Migration("20231118235130_removeGUID")]
    partial class removeGUID
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.25")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("WebApp.Entities.Person", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ID"), 1L, 1);

                    b.Property<int>("Age")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Surname")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("TotalMoney")
                        .HasColumnType("int");

                    b.HasKey("ID");

                    b.ToTable("Person");

                    b.HasData(
                        new
                        {
                            ID = 1,
                            Age = 28,
                            Name = "Ercument",
                            Surname = "Kalkan",
                            TotalMoney = 0
                        },
                        new
                        {
                            ID = 2,
                            Age = 27,
                            Name = "Ezgi",
                            Surname = "Gulsen",
                            TotalMoney = 0
                        });
                });
#pragma warning restore 612, 618
        }
    }
}
