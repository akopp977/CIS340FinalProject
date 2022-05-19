using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace finalProject.Models.DataLayer
{
    public partial class DBContext : DbContext
    {
        public DBContext()
        {
        }

        public DBContext(DbContextOptions<DBContext> options)
            : base(options)
        {
        }

        public virtual DbSet<CustomerTypes> CustomerTypes { get; set; }
        public virtual DbSet<Customers> Customers { get; set; }
        public virtual DbSet<Logins> Logins { get; set; }
        public virtual DbSet<ProductTypes> ProductTypes { get; set; }
        public virtual DbSet<Products> Products { get; set; }
        public virtual DbSet<TransactionItems> TransactionItems { get; set; }
        public virtual DbSet<Transactions> Transactions { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. See http://go.microsoft.com/fwlink/?LinkId=723263 for guidance on storing connection strings.
                optionsBuilder.UseSqlServer("Data Source=(LocalDB)\\MSSQLLocalDB; AttachDBFilename=C:\\Users\\Austin\\CIS340FinalProject\\finalProject\\Database1.mdf; Integrated security=True");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<CustomerTypes>(entity =>
            {
                entity.HasKey(e => e.CusTypeId)
                    .HasName("PK__Customer__2A0DCAF9BB37BFDC");

                entity.Property(e => e.CustomerType).IsFixedLength();
            });

            modelBuilder.Entity<Customers>(entity =>
            {
                entity.HasKey(e => e.CusId)
                    .HasName("PK__tmp_ms_x__0AD16557E31A7AE9");

                entity.HasIndex(e => e.Username)
                    .HasName("UQ__tmp_ms_x__536C85E4D8648217")
                    .IsUnique();

                entity.Property(e => e.Email).IsFixedLength();

                entity.Property(e => e.FirstName).IsFixedLength();

                entity.Property(e => e.LastName).IsFixedLength();

                entity.Property(e => e.PhoneNumber).IsFixedLength();

                entity.Property(e => e.Username).IsFixedLength();

                entity.HasOne(d => d.CusType)
                    .WithMany(p => p.Customers)
                    .HasForeignKey(d => d.CusTypeId)
                    .HasConstraintName("FK_Customers_Customer_Types");
            });

            modelBuilder.Entity<Logins>(entity =>
            {
                //entity.HasNoKey();

                entity.Property(e => e.Password).IsFixedLength();

                entity.Property(e => e.Username).IsFixedLength();

                entity.HasOne(d => d.Cus)
                    .WithMany()
                    .HasForeignKey(d => d.CusId)
                    .HasConstraintName("FK_Logins_ToTable_1");

                entity.HasOne(d => d.UsernameNavigation)
                    .WithMany()
                    .HasPrincipalKey(p => p.Username)
                    .HasForeignKey(d => d.Username)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Logins_ToTable");
            });

            modelBuilder.Entity<ProductTypes>(entity =>
            {
                entity.HasKey(e => e.TypeId)
                    .HasName("PK__Product___FE90DDFE98620CF4");

                entity.Property(e => e.Type).IsFixedLength();
            });

            modelBuilder.Entity<Products>(entity =>
            {
                entity.HasKey(e => e.ProdId)
                    .HasName("PK__Products__C55BDFF36BA9D61B");

                entity.Property(e => e.Desc).IsFixedLength();

                entity.Property(e => e.Name).IsFixedLength();

                entity.HasOne(d => d.Type)
                    .WithMany(p => p.Products)
                    .HasForeignKey(d => d.TypeId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Products_ToTable");
            });

            modelBuilder.Entity<TransactionItems>(entity =>
            {
                entity.HasKey(e => new { e.TranId, e.ProdId })
                    .HasName("PK__Transact__B95B5B2FD4D1D6ED");

                entity.HasOne(d => d.Prod)
                    .WithMany(p => p.TransactionItems)
                    .HasForeignKey(d => d.ProdId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Transaction_Items_ToTable_1");

                entity.HasOne(d => d.Tran)
                    .WithMany(p => p.TransactionItems)
                    .HasForeignKey(d => d.TranId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Transaction_Items_ToTable");
            });

            modelBuilder.Entity<Transactions>(entity =>
            {
                entity.HasKey(e => e.TranId)
                    .HasName("PK__Transact__950EE6D0B5EA586A");

                entity.HasOne(d => d.Cus)
                    .WithMany(p => p.Transactions)
                    .HasForeignKey(d => d.CusId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Transactions_ToTable");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
