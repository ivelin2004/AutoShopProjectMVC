using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace AutoShop1.Models
{
    public partial class Auto_ShopContext : DbContext
    {
        public Auto_ShopContext()
        {
        }

        public Auto_ShopContext(DbContextOptions<Auto_ShopContext> options)
            : base(options)
        {
        }

        public virtual DbSet<AutoShop> AutoShop { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. See http://go.microsoft.com/fwlink/?LinkId=723263 for guidance on storing connection strings.
                optionsBuilder.UseSqlServer("Server=18-07\\SQLEXPRESS;Database=Auto_Shop;Integrated Security=True;");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.HasAnnotation("ProductVersion", "2.2.2-servicing-10034");

            modelBuilder.Entity<AutoShop>(entity =>
            {
                entity.HasKey(e => e.IdCar);

                entity.ToTable("auto_shop");

                entity.Property(e => e.IdCar)
                    .HasColumnName("id_car")
                    .ValueGeneratedNever();

                entity.Property(e => e.CarColor)
                    .HasColumnName("car_color")
                    .HasMaxLength(50);

                entity.Property(e => e.CarLocation)
                    .HasColumnName("car_location")
                    .HasMaxLength(50);

                entity.Property(e => e.CarName)
                    .HasColumnName("car_name")
                    .HasMaxLength(50);

                entity.Property(e => e.CarPower)
                    .HasColumnName("car_power")
                    .HasMaxLength(50);

                entity.Property(e => e.CarPrice)
                    .HasColumnName("car_price")
                    .HasMaxLength(50);

                entity.Property(e => e.CarTransmission)
                    .HasColumnName("car_transmission")
                    .HasMaxLength(50);

                entity.Property(e => e.Manifacture)
                    .HasColumnName("manifacture")
                    .HasMaxLength(50);
            });
        }
    }
}
