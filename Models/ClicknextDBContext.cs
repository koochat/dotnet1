using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace dotnet1.Models
{
    public partial class ClicknextDBContext : DbContext
    {
        public ClicknextDBContext()
        {
            
        }

        public ClicknextDBContext(DbContextOptions<ClicknextDBContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Account> Account { get; set; }
        public virtual DbSet<UserInfo> UserInfo { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Account>(entity =>
            {
                entity.HasKey(e => e.AdminId);

                entity.Property(e => e.AdminId).HasColumnName("ADMIN_ID");

                entity.Property(e => e.Password)
                    .IsRequired()
                    .HasColumnName("PASSWORD")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.UserName)
                    .IsRequired()
                    .HasColumnName("USER_NAME")
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<UserInfo>(entity =>
            {
                entity.HasKey(e => e.UserId);

                entity.Property(e => e.UserId).HasColumnName("USER_ID");

                entity.Property(e => e.UserEmail)
                    .IsRequired()
                    .HasColumnName("USER_EMAIL")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.UserFirstname)
                    .IsRequired()
                    .HasColumnName("USER_FIRSTNAME")
                    .HasMaxLength(50);

                entity.Property(e => e.UserLastname)
                    .IsRequired()
                    .HasColumnName("USER_LASTNAME")
                    .HasMaxLength(50);

                entity.Property(e => e.UserName)
                    .IsRequired()
                    .HasColumnName("USER_NAME")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.UserPassword)
                    .IsRequired()
                    .HasColumnName("USER_PASSWORD")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.UserTelephone)
                    .IsRequired()
                    .HasColumnName("USER_TELEPHONE")
                    .HasMaxLength(10)
                    .IsUnicode(false);
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
