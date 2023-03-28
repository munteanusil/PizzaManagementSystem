using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace CapricciosaPizza.Models;
//reverse engineering context
public partial class LoyalCustomersContext : DbContext
{
    public LoyalCustomersContext()
    {
    }

    public LoyalCustomersContext(DbContextOptions<LoyalCustomersContext> options)
        : base(options)
    {
    }

    public virtual DbSet<TblLoyalCustomer> TblLoyalCustomers { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
        => optionsBuilder.UseSqlServer("Server=DESKTOP-CT3VKRI\\SQLEXPRESS;database=LoyalCustomers;Encrypt=False;TrustServerCertificate=False;Trusted_Connection=true;");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<TblLoyalCustomer>(entity =>
        {
            entity.ToTable("tblLoyalCustomers");

            entity.Property(e => e.Id).ValueGeneratedNever();
            entity.Property(e => e.Address)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Email)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.FirstName)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.LastName)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Phone)
                .HasMaxLength(50)
                .IsUnicode(false);
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
