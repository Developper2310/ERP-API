using Demo1.Data.Configurations;
using Demo1.Model;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;

namespace Demo1.Data
{
    
    public class AppDbContext : DbContext
    {
        protected readonly IConfiguration Configuration;
        public AppDbContext(IConfiguration configuration)
        {
            Configuration = configuration;
        }
        protected override void OnConfiguring(DbContextOptionsBuilder options)
        {
            options.UseNpgsql(Configuration.GetConnectionString("DefaultConnection"));
        }



        public DbSet<Calisan> Calisanlar { get; set; }
        public DbSet<Departman> Departmanlar { get; set; }
        public DbSet<Depo> Depolar { get; set; }
        public DbSet<DepoUrun> DepoUrunler { get; set; }
        public DbSet<FisDestek> FisDestekler { get; set; }
        public DbSet<Islem> Islemler { get; set; }
        public DbSet<Kategori> Kategoriler { get; set; }
        public DbSet<KullaniciIslem> KullaniciIslemler { get; set; }
        public DbSet<KullaniciRol> KullaniciRoller { get; set; }
        public DbSet<KullaniciSifre> KullaniciSifreleri { get; set; }
        public DbSet<Marka> Markalar { get; set; }
        public DbSet<Rol> Roller { get; set; }
        public DbSet<RolYetki> RolYetkileri { get; set; }
        public DbSet<Urun> Urunler { get; set; }
        public DbSet<Yetki> Yetkiler { get; set; }
        public DbSet<AlimSatim> AlimSatimlar { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.ApplyConfiguration(new AlimSatimConfiguration());
            modelBuilder.ApplyConfiguration(new CalisanConfiguration());
            modelBuilder.ApplyConfiguration(new DepartmanConfiguration());
            modelBuilder.ApplyConfiguration(new DepoConfiguration());
            modelBuilder.ApplyConfiguration(new DepoUrunConfiguration());
            modelBuilder.ApplyConfiguration(new FisDestekConfiguration());
            modelBuilder.ApplyConfiguration(new IslemConfiguration());
            modelBuilder.ApplyConfiguration(new KategoriConfiguration());
            modelBuilder.ApplyConfiguration(new KullaniciIslemConfiguration());
            modelBuilder.ApplyConfiguration(new KullaniciRolConfiguration());
            modelBuilder.ApplyConfiguration(new KullaniciSifreConfiguration());
            modelBuilder.ApplyConfiguration(new MarkaConfiguration());
            modelBuilder.ApplyConfiguration(new RolConfiguration());
            modelBuilder.ApplyConfiguration(new RolYetkiConfiguration());
            modelBuilder.ApplyConfiguration(new UrunConfiguration());
            modelBuilder.ApplyConfiguration(new YetkiConfiguration());
        }

    }
}
