using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.Database.Configuration;

/*
public class UserConfiguration : IEntityTypeConfiguration<User>
{
    public void Configure(EntityTypeBuilder<User> builder)
    {
        // Configuração da chave primária
    builder.HasKey(u => new { u.Id }); // Dessa forma é possivel configurar chave composta 

    // Propriedades simples
    builder.Property(u => u.DataString)
           .HasMaxLength(255)
           .IsRequired(false);  // Permitindo valor nulo

    builder.Property(u => u.DataInt)
           .IsRequired();

    builder.Property(u => u.DataDecimal)
           .HasColumnType("decimal(18,2)")
           .IsRequired();

    builder.Property(u => u.DataDateTime)
           .IsRequired();

    // Configuração das propriedades de auditoria
    builder.Property(u => u.DateCreated)
           .IsRequired();

    builder.Property(u => u.DateUpdated)
           .IsRequired(false);

    builder.Property(u => u.DateDeleted)
           .IsRequired(false);

    }
}
*/
