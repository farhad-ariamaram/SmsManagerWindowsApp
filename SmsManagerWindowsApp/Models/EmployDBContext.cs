using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

#nullable disable

namespace SmsManagerWindowsApp.Models
{
    public partial class EmployDBContext : DbContext
    {
        string connection;
        public EmployDBContext()
        {
            connection =System.Configuration.ConfigurationManager.ConnectionStrings["CS"].ConnectionString;
        }

        public EmployDBContext(DbContextOptions<EmployDBContext> options)
            : base(options)
        {
        }

        public virtual DbSet<TblLink> TblLinks { get; set; }
        public virtual DbSet<TblSmsReceived> TblSmsReceiveds { get; set; }
        public virtual DbSet<TblSmsSent> TblSmsSents { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlServer(connection);
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.HasAnnotation("Relational:Collation", "Persian_100_CI_AI");

            modelBuilder.Entity<TblLink>(entity =>
            {
                entity.ToTable("Tbl_Link");

                entity.Property(e => e.Id)
                    .HasMaxLength(50)
                    .UseCollation("Persian_100_CI_AS");

                entity.Property(e => e.ExpireDate).HasColumnType("datetime");

                entity.Property(e => e.Phone)
                    .HasMaxLength(50)
                    .UseCollation("Persian_100_CI_AS");
            });

            modelBuilder.Entity<TblSmsReceived>(entity =>
            {
                entity.ToTable("Tbl_SmsReceived");

                entity.Property(e => e.Date).HasColumnType("datetime");

                entity.Property(e => e.Message)
                    .HasMaxLength(1000)
                    .UseCollation("Persian_100_CI_AS");

                entity.Property(e => e.Phone)
                    .HasMaxLength(1000)
                    .UseCollation("Persian_100_CI_AS");
            });

            modelBuilder.Entity<TblSmsSent>(entity =>
            {
                entity.ToTable("Tbl_SmsSent");

                entity.Property(e => e.Date).HasColumnType("datetime");

                entity.Property(e => e.Message)
                    .HasMaxLength(1000)
                    .UseCollation("Persian_100_CI_AS");

                entity.Property(e => e.Phone)
                    .HasMaxLength(1000)
                    .UseCollation("Persian_100_CI_AS");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
