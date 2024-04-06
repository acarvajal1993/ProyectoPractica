using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using Tienda.Core.Entities;

namespace Tienda.Infrastracture.Configurations
{
    public class ProductoConfiguration : IEntityTypeConfiguration<Producto>
    {
        public void Configure(EntityTypeBuilder<Producto> entity)
        {
            entity.HasKey(e => e.IdProducto);

            entity.Property(e => e.Color)
                .HasMaxLength(250)
                .IsUnicode(false);

            entity.Property(e => e.Marca)
                .HasMaxLength(250)
                .IsUnicode(false);

            entity.Property(e => e.Nombre)
                .HasMaxLength(500)
                .IsUnicode(false);

            entity.Property(e => e.Precio).HasColumnType("decimal(18, 2)");

            entity.Property(e => e.PrecionPromocional).HasColumnType("decimal(18, 2)");
        }
    }
}
