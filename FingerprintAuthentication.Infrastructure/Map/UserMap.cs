using FingerprintAuthentication.Domain.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.Infrastructure.Annotations;
using System.Data.Entity.ModelConfiguration;
using System.Text;

namespace FingerprintAuthentication.Infrastructure.Map
{
    public class UserMap : EntityTypeConfiguration<User>
    {
        public UserMap()
        {
            ToTable("Usuario");

            Property(u => u.Id)
                .HasColumnOrder(1)
                .HasColumnName("Id")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);

            Property(u => u.Name)
                .HasColumnOrder(2)
                .HasColumnName("Nome")
                .HasMaxLength(255)
                .IsRequired();

            Property(u => u.Password)
                .HasColumnOrder(4)
                .HasColumnName("Senha")
                .HasMaxLength(32)
                .IsFixedLength()
                .IsRequired();
        }
    }
}
