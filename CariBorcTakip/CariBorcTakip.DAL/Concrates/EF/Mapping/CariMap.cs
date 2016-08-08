using CariBorcTakip.Entites;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace CariBorcTakip.DAL.Concrates.EF.Mapping
{
    public class CariMap : EntityTypeConfiguration<Cari>
    {
        public CariMap()
        {
            // Primary Key
            this.HasKey(t => t.CariID);

            // Properties
            this.Property(t => t.CariKOD)
                .HasMaxLength(35);

            this.Property(t => t.CariAd)
                .HasMaxLength(100);

            this.Property(t => t.Telefon)
            .HasMaxLength(25);

            this.Property(t => t.Adres)
                .HasMaxLength(250);

            // Table & Column Mappings
            this.ToTable("Caris");
            this.Property(t => t.CariID).HasColumnName("CariID");
            this.Property(t => t.CariKOD).HasColumnName("CariKOD");
            this.Property(t => t.CariAd).HasColumnName("CariAd");
            this.Property(t => t.Telefon).HasColumnName("Telefon");
            this.Property(t => t.Adres).HasColumnName("Adres");
            this.Property(t => t.IsDeleted).HasColumnName("IsDeleted");
        }
    }
}
