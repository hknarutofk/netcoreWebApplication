using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace netcoreWebApi_3_1.Models
{
    public partial class sbtestContext : DbContext
    {
        public sbtestContext()
        {
        }

        public sbtestContext(DbContextOptions<sbtestContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Efmigrationshistory> Efmigrationshistory { get; set; }
        public virtual DbSet<Sbtest1> Sbtest1 { get; set; }        

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Efmigrationshistory>(entity =>
            {
                entity.HasKey(e => e.MigrationId)
                    .HasName("PRIMARY");

                entity.ToTable("__efmigrationshistory");

                entity.Property(e => e.MigrationId)
                    .HasColumnType("varchar(150)")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_bin");

                entity.Property(e => e.ProductVersion)
                    .IsRequired()
                    .HasColumnType("varchar(32)")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_bin");
            });

            modelBuilder.Entity<Sbtest1>(entity =>
            {
                entity.ToTable("sbtest1");

                entity.HasIndex(e => e.K)
                    .HasName("k_1");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.C)
                    .IsRequired()
                    .HasColumnName("c")
                    .HasColumnType("char(120)")
                    .HasDefaultValueSql("''")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_0900_ai_ci");

                entity.Property(e => e.K).HasColumnName("k");

                entity.Property(e => e.Pad)
                    .IsRequired()
                    .HasColumnName("pad")
                    .HasColumnType("char(60)")
                    .HasDefaultValueSql("''")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_0900_ai_ci");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
