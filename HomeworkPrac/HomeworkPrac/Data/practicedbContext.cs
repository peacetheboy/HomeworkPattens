using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;
using HomeworkPrac.Models;

namespace HomeworkPrac.Data
{
    public partial class practicedbContext : DbContext
    {
        public practicedbContext()
        {
        }

        public practicedbContext(DbContextOptions<practicedbContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Product> Products { get; set; } = null!;
        public virtual DbSet<Service> Services { get; set; } = null!;
        public object Service { get; internal set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
                optionsBuilder.UseSqlServer("Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=practicedb;Integrated Security=True;Connect Timeout=30;Encrypt=False;Trust Server Certificate=False;Application Intent=ReadWrite;Multi Subnet Failover=False");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Product>(entity =>
            {
                entity.ToTable("Product");

                entity.Property(e => e.ProductId)
                    .ValueGeneratedNever()
                    .HasColumnName("ProductID");

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.ProductDescription).IsUnicode(false);

                entity.Property(e => e.ProductName).IsUnicode(false);
            });

            modelBuilder.Entity<Service>(entity =>
            {
                entity.ToTable("Service");

                entity.Property(e => e.ServiceId)
                    .ValueGeneratedNever()
                    .HasColumnName("ServiceID");

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.ServiceDescription).IsUnicode(false);

                entity.Property(e => e.ServiceName).IsUnicode(false);
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
