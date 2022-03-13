using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.EntityFrameworkCore;

namespace AutoShop1.Data.Models
{
    public partial class ShopContext : DbContext
    {
        public ShopContext()
        {
        }

        public ShopContext(DbContextOptions<ShopContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Shop> Shop { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlServer("Server=18-07\\SQLEXPRESS;Database=Auto_Shop;Integrated Security=True;");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.HasAnnotation("ProductVersion", "2.2.2-servicing-10034");

            modelBuilder.Entity<Shop>(entity =>
            {
                entity.HasKey(e => e.nameShop);

                entity.ToTable("name_shop");

                entity.Property(e => e.IdShop)
                    .HasColumnName("id_shop")
                    .ValueGeneratedNever();

                entity.Property(e => e.cityShop)
                    .HasColumnName("city_shop")
                    .HasMaxLength(50);

               
            });
        }
    }
}
