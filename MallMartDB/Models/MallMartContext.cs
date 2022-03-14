using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace MallMartDB.Models
{
    public partial class MallMartContext : DbContext
    {
        public MallMartContext()
        {
        }

        public MallMartContext(DbContextOptions<MallMartContext> options)
            : base(options)
        {
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
                optionsBuilder.UseSqlServer("Data Source=localhost\\SQLEXPRESS;Initial Catalog=MallMart;Integrated Security=True")
                    .EnableSensitiveDataLogging(true);
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            OnModelCreatingPartial(modelBuilder);

            modelBuilder.Entity<EmployeeRegion>(entity =>
            {
                entity.HasKey(e => new { e.EmployeeId, e.RegionId });

                entity.HasOne(d => d.Employee)
                    .WithMany(p => p.DeliveryRegions)
                    .HasForeignKey(d => d.EmployeeId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_EmployeeRegions_Employees");

                entity.HasOne(d => d.Region)
                    .WithMany(p => p.Employees)
                    .HasForeignKey(d => d.RegionId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_EmployeeRegions_Regions");
            });

            modelBuilder.Entity<Employee>(entity =>
            {
                entity.HasOne(d => d.Manager)
               .WithMany(p => p.Employees)
               .HasForeignKey(d => d.ManagerId)
               .HasConstraintName("FK__employees__managers")
               .OnDelete(DeleteBehavior.NoAction);

                entity.Property(e => e.ManagerId).IsRequired(false);
            });

            modelBuilder.Entity<Address>(entity =>
            {
                entity.Property(e => e.Entrance).IsRequired(false);
                entity.Property(e => e.ApartmentNo).IsRequired(false);
                entity.Property(e => e.Postal).IsRequired(false);
            });

            modelBuilder.Entity<AcquisitionOrder>(entity =>
            {
                entity.Property(e => e.ArrivalTime).IsRequired(false);
                entity.Property(e => e.EmployeeId).IsRequired(false);
                entity.Property(e => e.TotalPrice).IsRequired(false);
                entity.Property(e => e.PricePaid).IsRequired(false);
                entity.Property(e => e.Comment).IsRequired(false);
                entity.Property(o => o.DateOrdered).IsRequired(false);
                entity.Property(o => o.DueTimeFirst).IsRequired(false);
                entity.Property(o => o.DueTimeLast).IsRequired(false);
            });

            modelBuilder.Entity<AcquisitionOrderLine>(entity =>
            {
                entity.HasKey(e => new { e.AcquisitionOrderId, e.ProductId });

                entity.HasOne(d => d.AcquisitionOrder)
                    .WithMany(p => p.OrderLines)
                    .HasForeignKey(d => d.AcquisitionOrderId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_AcquisitionOrderLine_AcquisitionOrder");
            });

            modelBuilder.Entity<Order>(entity =>
            {
                entity.Property(e => e.ArrivalTime).IsRequired(false);
                entity.Property(e => e.EmployeeId).IsRequired(false);
                entity.Property(e => e.TotalPrice).IsRequired(false);
                entity.Property(e => e.PricePaid).IsRequired(false);
                entity.Property(e => e.Comment).IsRequired(false);
                entity.Property(o => o.DateOrdered).IsRequired(false);
                entity.Property(o => o.DueTimeFirst).IsRequired(false);
                entity.Property(o => o.DueTimeLast).IsRequired(false);
            });

            modelBuilder.Entity<OrderLine>(entity =>
            {
                entity.HasKey(e => new { e.OrderId, e.ProductId });

                entity.HasOne(d => d.Order)
                    .WithMany(p => p.OrderLines)
                    .HasForeignKey(d => d.OrderId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_OrderLine_Order");
            });

            modelBuilder.Entity<Product>(entity =>
            {
                entity.Property(e => e.Description).IsRequired(false);
                entity.Property(e => e.UnitsInStock).IsRequired(false);
                entity.Property(e => e.UnitPrice).IsRequired(false);
                entity.Property(e => e.UnitsOnOrder).IsRequired(false);
            });

            modelBuilder.Entity<Supplier>(entity =>
            {
                entity.Property(e => e.AddressId).IsRequired(false);
                entity.Property(e => e.Phone).IsRequired(false);
                entity.Property(e => e.Email).IsRequired(false);
            });

            modelBuilder.Entity<Category>().HasData(
                new Category() { Id = 1, Name = "Snacks" },
                new Category() { Id = 2, Name = "Frozen vegetables" },
                new Category() { Id = 3, Name = "Tin cans" },
                new Category() { Id = 4, Name = "Video Cards" },
                new Category() { Id = 5, Name = "Cars" },
                new Category() { Id = 6, Name = "Sweets" },
                new Category() { Id = 7, Name = "Other" }
                );
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
        public DbSet<AcquisitionOrder> AcquisitionOrders { get; set; }
        public DbSet<AcquisitionOrderLine> AcquisitionOrderLines { get; set; }
        public DbSet<Address> Addresses { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Customer> Customers { get; set; }
        public DbSet<Employee> Employees { get; set; }
        public DbSet<Order> Orders { get; set; }
        public DbSet<OrderLine> OrderLines { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<Region> Regions { get; set; }
        public DbSet<Supplier> Suppliers { get; set; }
        public DbSet<User> Users { get; set; }
        public DbSet<EmployeeRegion> EmployeeRegions { get; set; }
    }
}
