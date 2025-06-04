using ASEGURADORAS.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ASEGURADORAS.Data
{
    public class ApplicationDbContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);
            optionsBuilder.UseSqlServer("" +
                 "server=JOSSELIN-MONTOY\\JOSSELINMONTOYA;" +
                "Database = Aseguradoras;" +
                "Trusted_Connection = true;" +
                "MultipleActiveResultSets=true;" +
                "TrustServerCertificate=True;");

        }   
     

        public DbSet<AbankPago> AbankPagos { get; set; }
        public DbSet<AcsaPago> AcsaPagos { get; set; }
        public DbSet<AsesuizaPago> AsesuizaPagos { get; set; }
        public DbSet<AssaPago> AssaPagos { get; set; }
        public DbSet<MapfrePago> MapfrePagos { get; set; }
        public DbSet<PalicPago> PalicPagos { get; set; }
        public DbSet<QualitasPago> QualitasPagos { get; set; }

        public DbSet<Usuario> Contraseñas { get; set; }



        public ApplicationDbContext ()
        {

        }
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options) 
        {
            
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            // Configuración para cada entidad
            ConfigurePagoDecimalProps<AbankPago>(modelBuilder);
            ConfigurePagoDecimalProps<AcsaPago>(modelBuilder);
            ConfigurePagoDecimalProps<AsesuizaPago>(modelBuilder);
            ConfigurePagoDecimalProps<AssaPago>(modelBuilder);
            ConfigurePagoDecimalProps<MapfrePago>(modelBuilder);
            ConfigurePagoDecimalProps<PalicPago>(modelBuilder);
            ConfigurePagoDecimalProps<QualitasPago>(modelBuilder);

            // Configurar nombres de tabla 
            modelBuilder.Entity<AbankPago>().ToTable("AbankPagos");
            modelBuilder.Entity<AcsaPago>().ToTable("AcsaPagos");
            modelBuilder.Entity<AsesuizaPago>().ToTable("AsesuizaPagos");
            modelBuilder.Entity<AssaPago>().ToTable("AssaPagos");
            modelBuilder.Entity<MapfrePago>().ToTable("MapfrePagos");
            modelBuilder.Entity<PalicPago>().ToTable("PalicPagos");
            modelBuilder.Entity<QualitasPago>().ToTable("QualitasPagos");
        }

        
        private void ConfigurePagoDecimalProps<T>(ModelBuilder modelBuilder) where T : class
        {
            modelBuilder.Entity<T>().Property("MontoTotal").HasPrecision(18, 2);
            modelBuilder.Entity<T>().Property("Deducible").HasPrecision(18, 2);
            modelBuilder.Entity<T>().Property("CopagoPorcentaje").HasPrecision(18, 2);
            modelBuilder.Entity<T>().Property("PagoPaciente").HasPrecision(18, 2);
            modelBuilder.Entity<T>().Property("PagoAseguradora").HasPrecision(18, 2);
        }
        public class AseguradorasContext : DbContext
        {
           

            protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
            {
                optionsBuilder.UseSqlServer("JOSSELIN-MONTOY\\JOSSELINMONTOYA");
            }
        }
    }
}