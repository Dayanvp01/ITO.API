using ITO.API.DomainCommon.Entity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ITO.API.DomainDAL.Configurations
{
    public class DependenciaConfiguration : IEntityTypeConfiguration<Dependencia>
    {
        private static EntityTypeBuilder<Dependencia> Builder;

        public void Configure(EntityTypeBuilder<Dependencia> builder)
        {
            builder.ToTable("Dependencia");

            builder.HasKey(x => x.Id);

            builder.Property(x => x.Id)
                .HasColumnName("Id")
                .HasDefaultValueSql("(newid())");

            builder.Property(x => x.Nombre)
            .UsePropertyAccessMode(PropertyAccessMode.Field)
            .HasColumnName("Nombre")
            .IsRequired()
            .HasMaxLength(100);

            builder.Property(x => x.Codigo)
            .UsePropertyAccessMode(PropertyAccessMode.Field)
            .HasColumnName("Codigo")
            .IsRequired()
            .HasMaxLength(10);

            builder.Property(x => x.Activo)
             .UsePropertyAccessMode(PropertyAccessMode.Field)
             .HasColumnName("Activo")
             .IsRequired()
             .HasDefaultValue(true);


            Builder = builder;
        }

    }
}
