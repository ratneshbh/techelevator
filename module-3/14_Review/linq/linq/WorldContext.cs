using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

#nullable disable

namespace linq
{
    public partial class WorldContext : DbContext
    {
        public WorldContext()
        {
        }

        public WorldContext(DbContextOptions<WorldContext> options)
            : base(options)
        {
        }

        public virtual DbSet<City> Cities { get; set; }
        public virtual DbSet<Country> Countries { get; set; }
        public virtual DbSet<Countrylanguage> Countrylanguages { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
                optionsBuilder.UseSqlServer("Data Source=.\\SQLExpress;Database=World;Trusted_Connection=True;");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.HasAnnotation("Relational:Collation", "SQL_Latin1_General_CP1_CI_AS");

            modelBuilder.Entity<City>(entity =>
            {
                entity.ToTable("city");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Countrycode)
                    .IsRequired()
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .HasColumnName("countrycode")
                    .IsFixedLength(true);

                entity.Property(e => e.District)
                    .IsRequired()
                    .HasMaxLength(64)
                    .IsUnicode(false)
                    .HasColumnName("district");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(64)
                    .IsUnicode(false)
                    .HasColumnName("name");

                entity.Property(e => e.Population).HasColumnName("population");

                entity.HasOne(d => d.CountrycodeNavigation)
                    .WithMany(p => p.Cities)
                    .HasForeignKey(d => d.Countrycode)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_countrycode");
            });

            modelBuilder.Entity<Country>(entity =>
            {
                entity.HasKey(e => e.Code)
                    .HasName("pk_country_code");

                entity.ToTable("country");

                entity.Property(e => e.Code)
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .HasColumnName("code")
                    .IsFixedLength(true);

                entity.Property(e => e.Capital).HasColumnName("capital");

                entity.Property(e => e.Code2)
                    .IsRequired()
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .HasColumnName("code2")
                    .IsFixedLength(true);

                entity.Property(e => e.Continent)
                    .IsRequired()
                    .HasMaxLength(64)
                    .IsUnicode(false)
                    .HasColumnName("continent");

                entity.Property(e => e.Gnp)
                    .HasColumnType("numeric(10, 2)")
                    .HasColumnName("gnp");

                entity.Property(e => e.Gnpold)
                    .HasColumnType("numeric(10, 2)")
                    .HasColumnName("gnpold");

                entity.Property(e => e.Governmentform)
                    .IsRequired()
                    .HasMaxLength(64)
                    .IsUnicode(false)
                    .HasColumnName("governmentform");

                entity.Property(e => e.Headofstate)
                    .HasMaxLength(64)
                    .IsUnicode(false)
                    .HasColumnName("headofstate");

                entity.Property(e => e.Indepyear).HasColumnName("indepyear");

                entity.Property(e => e.Lifeexpectancy).HasColumnName("lifeexpectancy");

                entity.Property(e => e.Localname)
                    .IsRequired()
                    .HasMaxLength(64)
                    .IsUnicode(false)
                    .HasColumnName("localname");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(64)
                    .IsUnicode(false)
                    .HasColumnName("name");

                entity.Property(e => e.Population).HasColumnName("population");

                entity.Property(e => e.Region)
                    .IsRequired()
                    .HasMaxLength(64)
                    .IsUnicode(false)
                    .HasColumnName("region");

                entity.Property(e => e.Surfacearea).HasColumnName("surfacearea");

                entity.HasOne(d => d.CapitalNavigation)
                    .WithMany(p => p.Countries)
                    .HasForeignKey(d => d.Capital)
                    .HasConstraintName("FK__country__capital__3E52440B");
            });

            modelBuilder.Entity<Countrylanguage>(entity =>
            {
                entity.HasKey(e => new { e.Countrycode, e.Language })
                    .HasName("pk_countrylanguage_countrycode_language");

                entity.ToTable("countrylanguage");

                entity.Property(e => e.Countrycode)
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .HasColumnName("countrycode")
                    .IsFixedLength(true);

                entity.Property(e => e.Language)
                    .HasMaxLength(64)
                    .IsUnicode(false)
                    .HasColumnName("language");

                entity.Property(e => e.Isofficial).HasColumnName("isofficial");

                entity.Property(e => e.Percentage).HasColumnName("percentage");

                entity.HasOne(d => d.CountrycodeNavigation)
                    .WithMany(p => p.Countrylanguages)
                    .HasForeignKey(d => d.Countrycode)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_countrylanguage_countrycode");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
