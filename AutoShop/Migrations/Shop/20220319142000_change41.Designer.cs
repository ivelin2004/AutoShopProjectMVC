﻿// <auto-generated />
using AutoShop1.Data.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace AutoShop1.Migrations.Shop
{
    [DbContext(typeof(ShopContext))]
    [Migration("20220319142000_change41")]
    partial class change41
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.2.2-servicing-10034")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("AutoShop1.Data.Models.Shop", b =>
                {
                    b.Property<int>("IdShop")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("cityShop");

                    b.Property<string>("nameShop");

                    b.HasKey("IdShop")
                        .HasName("PK_Shop");

                    b.ToTable("Shop");
                });
#pragma warning restore 612, 618
        }
    }
}
