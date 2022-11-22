﻿using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace API_Apps.models
{
    public partial class eShoppingCodiContext : DbContext
    {
        public eShoppingCodiContext()
        {
        }

        public eShoppingCodiContext(DbContextOptions<eShoppingCodiContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Catagory> Catagories { get; set; } = null!;
        public virtual DbSet<Product> Products { get; set; } = null!;

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
//            if (!optionsBuilder.IsConfigured)
//            {
//#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
//                optionsBuilder.UseSqlServer("data source=PLONDHE-LAP-072\\MSSQLSERVER01;initial catalog=eShoppingCodi;Integrated Security=SSPI");
//            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Catagory>(entity =>
            {
                entity.ToTable("Catagory");

                entity.Property(e => e.CatagoryId).ValueGeneratedNever();

                entity.Property(e => e.CatagoryName)
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Product>(entity =>
            {
                entity.ToTable("Product");

                entity.Property(e => e.Description)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.ProductName)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                //entity.HasOne(d => d.Catagory)
                //    .WithMany(p => p.Products)
                //    .HasForeignKey(d => d.CatagoryId)
                //    .OnDelete(DeleteBehavior.ClientSetNull)
                //    .HasConstraintName("FK__Product__Catagor__2A4B4B5E");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
