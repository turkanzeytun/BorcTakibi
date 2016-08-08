using CariBorcTakip.Entites;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace CariBorcTakip.DAL.Concrates.EF.Mapping
{
    public class OdemeMap : EntityTypeConfiguration<Odeme>
    {
        public OdemeMap()
        {
            // Primary Key
            this.HasKey(t => t.OdemeID);
            
            // Properties
            this.Property(t => t.OdemeTuru)
                .HasMaxLength(100);

            this.Property(t => t.Aciklama)
               .HasMaxLength(500);

            // Table & Column Mappings
            this.ToTable("Odemes");
            this.Property(t => t.OdemeID).HasColumnName("OdemeID");
            this.Property(t => t.IsID).HasColumnName("IsID");
            this.Property(t => t.Tarih).HasColumnName("Tarih");
            this.Property(t => t.OdenenTutar).HasColumnName("OdenenTutar");
            this.Property(t => t.OdemeTuru).HasColumnName("OdemeTuru");
            this.Property(t => t.Aciklama).HasColumnName("Aciklama");
            this.Property(t => t.IsDeleted).HasColumnName("IsDeleted");

            // Relationships
            this.HasOptional(t => t.Iss)
                .WithMany(t => t.Odemes)
                .HasForeignKey(d => d.IsID);

        }
    }
}
