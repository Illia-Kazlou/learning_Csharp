using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

#nullable disable

namespace EFCoreDataBaseFirst
{
    public partial class TestContext : DbContext
    {
        public TestContext()
        {
        }

        public TestContext(DbContextOptions<TestContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Customer> Customers { get; set; }
        public virtual DbSet<Manager> Managers { get; set; }
        public virtual DbSet<Order> Orders { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlServer("Server=(localdb)\\MSSQLLocalDB; Database=Test; Trusted_Connection=True;");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.HasAnnotation("Relational:Collation", "SQL_Latin1_General_CP1_CI_AS");

            modelBuilder.Entity<Customer>(entity =>
            {
                entity.ToTable("CUSTOMERS");

                entity.HasIndex(e => e.ManagerId, "fkIdx_16");

                entity.Property(e => e.Id)
                    .ValueGeneratedNever()
                    .HasColumnName("ID");

                entity.Property(e => e.ManagerId).HasColumnName("MANAGER_ID");

                entity.Property(e => e.Name1)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasColumnName("NAME_1");

                entity.HasOne(d => d.Manager)
                    .WithMany(p => p.Customers)
                    .HasForeignKey(d => d.ManagerId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_16");
            });

            modelBuilder.Entity<Manager>(entity =>
            {
                entity.ToTable("MANAGERS");

                entity.Property(e => e.Id)
                    .ValueGeneratedNever()
                    .HasColumnName("ID");

                entity.Property(e => e.Name1)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasColumnName("NAME_1");
            });

            modelBuilder.Entity<Order>(entity =>
            {
                entity.ToTable("ORDERS");

                entity.HasIndex(e => e.CustomerId, "fkIdx_24");

                entity.Property(e => e.Id)
                    .ValueGeneratedNever()
                    .HasColumnName("ID");

                entity.Property(e => e.Amount1).HasColumnName("AMOUNT_1");

                entity.Property(e => e.CustomerId).HasColumnName("CUSTOMER_ID");

                entity.Property(e => e.Date1)
                    .HasColumnType("datetime")
                    .HasColumnName("DATE_1");

                entity.HasOne(d => d.Customer)
                    .WithMany(p => p.Orders)
                    .HasForeignKey(d => d.CustomerId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_24");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
