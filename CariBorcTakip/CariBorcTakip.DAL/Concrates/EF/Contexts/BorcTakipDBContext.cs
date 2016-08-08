using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using CariBorcTakip.Entites;
using CariBorcTakip.DAL.Concrates.EF.Mapping;
using CariBorcTakip.DAL.Migrations;

namespace CariBorcTakip.DAL.Concrates.EF.Contexts
{
    public partial class BorcTakipDBContext : DbContext
    {
        //static BorcTakipDBContext()
        //{
        //    Database.SetInitializer<BorcTakipDBContext>(new MigrateDatabaseToLatestVersion<BorcTakipDBContext, Configuration>());
        //}

        static BorcTakipDBContext()
        {
            Database.SetInitializer<BorcTakipDBContext>(null);
        }

        //public BorcTakipDBContext()
        //    : base("Name=BorcTakipDBContext")
        //{
        //}

        public DbSet<Cari> Caris { get; set; }
        public DbSet<Iss> Isses { get; set; }
        public DbSet<Odeme> Odemes { get; set; }
        public DbSet<Cek> Ceks { get; set; }
        public DbSet<sysdiagram> sysdiagrams { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Configurations.Add(new CariMap());
            modelBuilder.Configurations.Add(new IssMap());
            modelBuilder.Configurations.Add(new OdemeMap());
            modelBuilder.Configurations.Add(new CekMap());
            modelBuilder.Configurations.Add(new sysdiagramMap());
        }
    }
}
