using ITO.API.DomainCommon.Entity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ITO.API.DomainDAL.Configurations
{
    public class EmpleadosConfiguration : IEntityTypeConfiguration<Empleado>
    {
        private static EntityTypeBuilder<Empleado> Builder;
        public void Configure(EntityTypeBuilder<Empleado> builder)
        {
            builder.ToTable("Empleados");

            builder.HasKey(x => x.Id);

            builder.Property(x => x.Id)
                .HasColumnName("Id")
                .HasDefaultValueSql("(newid())");

            builder.Property(x => x.DependenciaId)
             .IsRequired()
             .HasColumnName("DependenciaId");

            builder.HasOne(x => x.Dependencia)
             .WithMany(y=> y.Empleados)
             .HasForeignKey(x => x.DependenciaId)
             .OnDelete(DeleteBehavior.Restrict)
             .HasConstraintName("FK_Empleado_Dependencia");

            builder.Property(x => x.Nombres)
           .UsePropertyAccessMode(PropertyAccessMode.Field)
           .HasColumnName("Nombres")
           .IsRequired()
           .HasMaxLength(100);

            builder.Property(x => x.Apellidos)
            .UsePropertyAccessMode(PropertyAccessMode.Field)
            .HasColumnName("Apellidos")
            .IsRequired()
            .HasMaxLength(100);

            builder.Property(x => x.Activo)
             .UsePropertyAccessMode(PropertyAccessMode.Field)
             .HasColumnName("Activo")
             .IsRequired()
             .HasDefaultValue(true);


            Builder = builder;
        }

    }
}
