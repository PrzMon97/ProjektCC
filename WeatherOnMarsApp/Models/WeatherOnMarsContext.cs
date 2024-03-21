using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace WeatherOnMarsApp.Models;

public partial class WeatherOnMarsContext : DbContext
{
    public WeatherOnMarsContext()
    {
    }

    public WeatherOnMarsContext(DbContextOptions<WeatherOnMarsContext> options)
        : base(options)
    {
    }

    public virtual DbSet<WeatherDatum> WeatherData { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see https://go.microsoft.com/fwlink/?LinkId=723263.
        => optionsBuilder.UseSqlServer("Server=tcp:weatheronmars.database.windows.net,1433;Initial Catalog=WeatherOnMars;Persist Security Info=False;User ID=adminMJJ;Password=projektCC_1;MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=False;Connection Timeout=30;");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<WeatherDatum>(entity =>
        {
            entity.ToTable("weather_data");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.AtmoOpacity)
                .HasMaxLength(50)
                .HasColumnName("atmo_opacity");
            entity.Property(e => e.MaxTemp).HasColumnName("max_temp");
            entity.Property(e => e.MinTemp).HasColumnName("min_temp");
            entity.Property(e => e.Pressure).HasColumnName("pressure");
            entity.Property(e => e.TerrestrialDate)
                .HasColumnType("datetime")
                .HasColumnName("terrestrial_date");
            entity.Property(e => e.WindSpeed).HasColumnName("wind_speed");
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
