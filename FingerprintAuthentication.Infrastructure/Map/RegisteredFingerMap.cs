using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

using FingerprintAuthentication.Domain.Model;

namespace FingerprintAuthentication.Infrastructure.Map
{
    public class RegisteredFingerMap : EntityTypeConfiguration<RegisteredFinger>
    {
        public RegisteredFingerMap()
        {
            ToTable("Dedo");

            Property(rf => rf.Id)
                .HasColumnOrder(1)
                .HasColumnName("Id")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);

            Property(rf => rf.Finger.Name)
                .HasColumnOrder(2)
                .HasColumnName("Nome")
                .HasMaxLength(255)
                .IsRequired();

            Property(rf => rf.EncodedText)
                .HasColumnOrder(4)
                .HasColumnName("Dados")
                .HasMaxLength(32)
                .IsFixedLength()
                .IsRequired();

            HasRequired(rf => rf.User)
                .WithMany(u => u.Fingers)
                .Map(r => r.MapKey("Ded_UsuId"))
                .WillCascadeOnDelete(true);
        }
    }
}
