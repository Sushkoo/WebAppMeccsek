﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using WebApplication1.Models;

#nullable disable

namespace WebApplication1.Migrations
{
    [DbContext(typeof(FociDbContext))]
    partial class FociDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder.HasAnnotation("ProductVersion", "8.0.8");

            modelBuilder.Entity("WebApplication1.Models.Meccs", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<int>("Fordulo")
                        .HasColumnType("INTEGER");

                    b.Property<string>("hazaiCsapatnev")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<int>("hazaiGolFelidoben")
                        .HasColumnType("INTEGER");

                    b.Property<int>("hazaiVeg")
                        .HasColumnType("INTEGER");

                    b.Property<string>("vendegCsapatnev")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<int>("vendegGolFelidoben")
                        .HasColumnType("INTEGER");

                    b.Property<int>("vendegVeg")
                        .HasColumnType("INTEGER");

                    b.HasKey("Id");

                    b.ToTable("Meccsek");
                });
#pragma warning restore 612, 618
        }
    }
}
