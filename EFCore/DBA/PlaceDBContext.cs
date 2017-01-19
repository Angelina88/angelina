using Microsoft.EntityFrameworkCore;
using System.Configuration;
using EFCore.Domain;


namespace EFCore
{
    /// <summary>
    /// Контекст базы данных для ef
    /// </summary>
    internal partial class PlaceDBContext : DbContext
    {
        public virtual DbSet<City> City { get; set; }
        public virtual DbSet<Engine> Engine { get; set; }
        public virtual DbSet<Place> Place { get; set; }
        public virtual DbSet<Service> Service { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseNpgsql(ConfigurationManager.ConnectionStrings["testDB"].ConnectionString);
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<City>(entity =>
            {
                entity.HasKey(e => e.Id)
                    .HasName("PK_city");

                entity.ToTable("city");

                entity.Property(e => e.Id)
                    .HasColumnName("recid")
                    .ValueGeneratedNever();

                entity.Property(e => e.Created).HasColumnName("reccreated");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasColumnName("recname")
                    .HasColumnType("varchar")
                    .HasMaxLength(255);

                entity.Property(e => e.Updated).HasColumnName("recupdated");
            });

            modelBuilder.Entity<Engine>(entity =>
            {
                entity.HasKey(e => e.Id)
                    .HasName("PK_engine");

                entity.ToTable("engine");

                entity.Property(e => e.Id)
                    .HasColumnName("recid")
                    .ValueGeneratedNever();

                entity.Property(e => e.Created).HasColumnName("reccreated");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasColumnName("recname")
                    .HasColumnType("varchar")
                    .HasMaxLength(255);

                entity.Property(e => e.Updated).HasColumnName("recupdated");
            });

            modelBuilder.Entity<Place>(entity =>
            {
                entity.HasKey(e => e.Id)
                    .HasName("PK_place");

                entity.ToTable("place");

                entity.HasIndex(e => e.CityId)
                    .HasName("place_IX_CityId");

                entity.HasIndex(e => e.EngineId)
                    .HasName("place_IX_EngineId");

                entity.HasIndex(e => e.Enabled)
                    .HasName("place_IX_IsEnabled");

                entity.HasIndex(e => e.PlaceTypeId)
                    .HasName("place_IX_placeTypeId");

                entity.Property(e => e.Id)
                    .HasColumnName("recid")
                    .ValueGeneratedNever();

                entity.Property(e => e.Address)
                    .IsRequired()
                    .HasColumnName("address")
                    .HasColumnType("varchar")
                    .HasMaxLength(255);

                entity.Property(e => e.AttributesJson).HasColumnName("attributesjson");

                entity.Property(e => e.CityId).HasColumnName("cityid");

                entity.Property(e => e.ContactInfo)
                    .HasColumnName("contactinfo")
                    .HasColumnType("varchar")
                    .HasMaxLength(255);

                entity.Property(e => e.EndPoint)
                    .IsRequired()
                    .HasColumnName("endpoint")
                    .HasColumnType("varchar")
                    .HasMaxLength(255);

                entity.Property(e => e.EngineId).HasColumnName("engineid");

                entity.Property(e => e.GroupName)
                    .IsRequired()
                    .HasColumnName("groupname")
                    .HasColumnType("varchar")
                    .HasMaxLength(255);

                entity.Property(e => e.Enabled).HasColumnName("isenabled");

                entity.Property(e => e.OriginalPlaceId)
                    .HasColumnName("originalplaceid")
                    .HasColumnType("varchar")
                    .HasMaxLength(255);

                entity.Property(e => e.PlaceTypeId).HasColumnName("placetypeid");

                entity.Property(e => e.Created).HasColumnName("reccreated");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasColumnName("recname")
                    .HasColumnType("varchar")
                    .HasMaxLength(255);

                entity.Property(e => e.Updated).HasColumnName("recupdated");
            });

            modelBuilder.Entity<Service>(entity =>
            {
                entity.HasKey(e => e.Id)
                    .HasName("PK_service");

                entity.ToTable("service");

                entity.HasIndex(e => e.IsEnabled)
                    .HasName("service_IX_IsEnabled");

                entity.HasIndex(e => e.PlaceId)
                    .HasName("service_IX_PlaceId");

                entity.Property(e => e.Id)
                    .HasColumnName("recid")
                    .ValueGeneratedNever();

                entity.Property(e => e.AttributesJson).HasColumnName("attributesjson");

                entity.Property(e => e.BookingExists).HasColumnName("isbookingexists");

                entity.Property(e => e.CancelBookingExists).HasColumnName("iscancelbookingexists");

                entity.Property(e => e.CancelServiceExists).HasColumnName("iscancelserviceexists");

                entity.Property(e => e.IsEnabled).HasColumnName("isenabled");

                entity.Property(e => e.SpecialistStepExists).HasColumnName("isspecialiststepexists");

                entity.Property(e => e.OriginalServiceId)
                    .HasColumnName("originalserviceid")
                    .HasColumnType("varchar")
                    .HasMaxLength(50);

                entity.Property(e => e.OriginalServiceName)
                    .IsRequired()
                    .HasColumnName("originalservicename")
                    .HasColumnType("varchar")
                    .HasMaxLength(255);

                entity.Property(e => e.PlaceId).HasColumnName("placeid");

                entity.Property(e => e.Created).HasColumnName("reccreated");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasColumnName("recname")
                    .HasColumnType("varchar")
                    .HasMaxLength(255);

                entity.Property(e => e.Updated).HasColumnName("recupdated");
            });
        }
    }
}