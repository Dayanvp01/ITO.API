using ITO.API.DomainBL;
using ITO.API.DomainCommon.Entity;
using ITO.API.DomainDAL.Configurations;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ITO.API.DomainDAL
{
    public class DomainContext: DbContext
    {
        public DomainContext(DbContextOptions<DomainContext> options) : base(options)
        {

        }

        /// <summary>
        /// Carga configuración
        /// </summary>
        /// <param name="modelBuilder"></param>
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {

            modelBuilder.ApplyConfiguration(new DependenciaConfiguration());
            modelBuilder.ApplyConfiguration(new EmpleadosConfiguration());
        }

        /// <summary>
        /// Configuración de la base de datos
        /// </summary>
        /// <param name="optionsBuilder"></param>
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlServer(StartupDomainBL.ConnectionString);
            }
        }

        public virtual DbSet<Dependencia> Dependencia { get; set; }
        public virtual DbSet<Empleado> Empleados { get; set; }

    }
}
