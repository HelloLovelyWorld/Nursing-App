using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

#nullable disable

namespace BoobieBusiness.Models
{
    public partial class BBDataContext : DbContext
    {
        public BBDataContext()
        {
        }

        public BBDataContext(DbContextOptions<BBDataContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Baby> Babies { get; set; }
        public virtual DbSet<Diaper> Diapers { get; set; }
        public virtual DbSet<FeedingLog> FeedingLogs { get; set; }
        public virtual DbSet<MilkStorage> MilkStorages { get; set; }
        public virtual DbSet<Mom> Moms { get; set; }
        public virtual DbSet<Sleep> Sleeps { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
                optionsBuilder.UseSqlServer("Data Source=(localdb)\\ProjectsV13;Initial Catalog=BBData;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.HasAnnotation("Relational:Collation", "SQL_Latin1_General_CP1_CI_AS");

            modelBuilder.Entity<Baby>(entity =>
            {
                entity.ToTable("Baby");

                entity.Property(e => e.BabyId)
                    .ValueGeneratedNever()
                    .HasColumnName("Baby ID");

                entity.Property(e => e.DateOfBirth)
                    .HasColumnType("datetime")
                    .HasColumnName("Date Of Birth");

                entity.Property(e => e.FirstName)
                    .HasMaxLength(50)
                    .HasColumnName("First Name");

                entity.Property(e => e.LastName)
                    .HasMaxLength(50)
                    .HasColumnName("Last Name");

                entity.Property(e => e.MomId)
                    .ValueGeneratedOnAdd()
                    .HasColumnName("Mom ID");
            });

            modelBuilder.Entity<Diaper>(entity =>
            {
                entity.HasNoKey();

                entity.Property(e => e.BabyId).HasColumnName("Baby ID");

                entity.Property(e => e.DateOfDiaperChang)
                    .HasColumnType("datetime")
                    .HasColumnName("Date of Diaper Chang");

                entity.Property(e => e.MomId)
                    .ValueGeneratedOnAdd()
                    .HasColumnName("Mom ID");

                entity.Property(e => e.NumberOfMixedDiapers).HasColumnName("Number of Mixed Diapers");

                entity.Property(e => e.NumberOfSoiledDiapers).HasColumnName("Number of Soiled Diapers");

                entity.Property(e => e.NumberOfUrineDiapers).HasColumnName("Number of Urine Diapers");
            });

            modelBuilder.Entity<FeedingLog>(entity =>
            {
                entity.HasKey(e => e.BabyId)
                    .HasName("PK__FeedingL__6098F5DEBDE9BFA2");

                entity.ToTable("FeedingLog");

                entity.Property(e => e.BabyId).HasColumnName("Baby ID");

                entity.Property(e => e.AmountFed).HasColumnName("Amount Fed");

                entity.Property(e => e.MilkId).HasColumnName("Milk ID");

                entity.Property(e => e.TimeFed)
                    .HasColumnType("datetime")
                    .HasColumnName("Time Fed");

                entity.HasOne(d => d.Milk)
                    .WithMany(p => p.FeedingLogs)
                    .HasForeignKey(d => d.MilkId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__FeedingLo__Milk __2C3393D0");
            });

            modelBuilder.Entity<MilkStorage>(entity =>
            {
                entity.HasKey(e => e.MomId)
                    .HasName("PK__MilkStor__1B4D6EBAADB0E891");

                entity.ToTable("MilkStorage");

                entity.Property(e => e.MomId).HasColumnName("Mom ID");

                entity.Property(e => e.AmountStored).HasColumnName("Amount Stored");

                entity.Property(e => e.BabyId).HasColumnName("Baby ID");

                entity.Property(e => e.DateStored)
                    .HasColumnType("datetime")
                    .HasColumnName("Date Stored");

                entity.HasOne(d => d.Baby)
                    .WithMany(p => p.MilkStorages)
                    .HasForeignKey(d => d.BabyId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__MilkStora__Baby __2D27B809");
            });

            modelBuilder.Entity<Mom>(entity =>
            {
                entity.ToTable("Mom");

                entity.Property(e => e.MomId).HasColumnName("Mom ID");

                entity.Property(e => e.BabyId).HasColumnName("Baby ID");

                entity.Property(e => e.FirstName)
                    .HasMaxLength(50)
                    .HasColumnName("First Name");

                entity.Property(e => e.LastName)
                    .HasMaxLength(50)
                    .HasColumnName("Last Name");

                entity.Property(e => e.NumberOfBabies)
                    .HasColumnType("datetime")
                    .HasColumnName("Number Of Babies");
            });

            modelBuilder.Entity<Sleep>(entity =>
            {
                entity.HasKey(e => e.BabyId);

                entity.ToTable("Sleep");

                entity.Property(e => e.BabyId)
                    .ValueGeneratedNever()
                    .HasColumnName("Baby ID");

                entity.Property(e => e.EndSleepTime)
                    .HasColumnType("datetime")
                    .HasColumnName("End Sleep Time");

                entity.Property(e => e.MomId)
                    .ValueGeneratedOnAdd()
                    .HasColumnName("Mom ID");

                entity.Property(e => e.StartSleepTime)
                    .HasColumnType("datetime")
                    .HasColumnName("Start Sleep Time");

                entity.Property(e => e.TotalSleepTimeIn24Hours).HasColumnName("Total Sleep Time In 24 Hours");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
