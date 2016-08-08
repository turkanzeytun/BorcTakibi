using CariBorcTakip.Entites;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CariBorcTakip.DAL.Concrates.EF.Mapping
{
    public class CekMap : EntityTypeConfiguration<Cek>
    {
        public CekMap()
        {
            // Primary Key
            this.HasKey(t => t.CekOdemeID);

            // Properties

            // Table & Column Mappings
            this.ToTable("Ceks");
            this.Property(t => t.CekOdemeID).HasColumnName("CekOdemeID");
            this.Property(t => t.OdemeID).HasColumnName("OdemeID");
            this.Property(t => t.SonOdemeTarihi).HasColumnName("SonOdemeTarihi");
            this.Property(t => t.OdendiMi).HasColumnName("OdendiMi");
            this.Property(t => t.IsDeleted).HasColumnName("IsDeleted");

            // Relationships
            this.HasOptional(t => t.Odeme)
                .WithMany(t => t.Ceks)
                .HasForeignKey(d => d.OdemeID);

        }
    }
}
