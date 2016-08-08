using CariBorcTakip.Entites;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace CariBorcTakip.DAL.Concrates.EF.Mapping
{
    public class IssMap : EntityTypeConfiguration<Iss>
    {
        public IssMap()
        {
            // Primary Key
            this.HasKey(t => t.IsID);

            // Properties
            this.Property(t => t.YapilanIsTanimi)
                .HasMaxLength(500);

            // Table & Column Mappings
            this.ToTable("Isses");
            this.Property(t => t.IsID).HasColumnName("IsID");
            this.Property(t => t.Tarih).HasColumnName("Tarih");
            this.Property(t => t.CariID).HasColumnName("CariID");
            this.Property(t => t.YapilanIsTanimi).HasColumnName("YapilanIsTanimi");
            this.Property(t => t.AlinacakTutar).HasColumnName("AlinacakTutar");
            this.Property(t => t.IsDeleted).HasColumnName("IsDeleted");

            // Relationships
            this.HasOptional(t => t.Cari)
                .WithMany(t => t.Isses)
                .HasForeignKey(d => d.CariID);

        }
    }
}
