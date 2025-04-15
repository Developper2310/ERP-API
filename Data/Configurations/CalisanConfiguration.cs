using Demo1.Model;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;

namespace Demo1.Data.Configurations
{
    public class CalisanConfiguration : IEntityTypeConfiguration<Calisan>
    {
        public void Configure(EntityTypeBuilder<Calisan> builder)
        {

        
            builder.HasKey(c => c.Id);

            builder.Property(c => c.Ad).IsRequired().HasMaxLength(100);
            builder.Property(c => c.Soyad).IsRequired().HasMaxLength(100);
            builder.Property(c => c.Email).HasMaxLength(200);
            builder.Property(c => c.IseBaslamaTarihi).IsRequired().HasMaxLength(200);
            builder.HasIndex(c => c.Email).IsUnique();



            //-------------------------------------------------------------------
            //Departmanlar
            builder.HasOne(c => c.Departman)
                .WithMany(d => d.Calisanlar)
                 .HasForeignKey(c => c.DepartmanID);//fk <--

            //KullaniciRolleri
            builder.HasMany(kr => kr.KullaniciRolleri)
                .WithOne(c => c.Calisan)
                .HasForeignKey(kr=>kr.CalisanID);

            //şifreler
            builder.HasMany(c => c.KullaniciSifreleri)
                .WithOne(ks => ks.Calisan)
                .HasForeignKey(c=>c.CalisanID);

            //AlimSatim
            builder.HasMany(c => c.AlimSatimlar)
                .WithOne(ast => ast.Calisan)
                .HasForeignKey(c=>c.CalisanID);

            //kullaniciIslemleri
            builder.HasMany(c => c.KullaniciIslemleri)
                .WithOne(ki => ki.Calisan)
                .HasForeignKey(c=>c.CalisanID);

        }
    }
}
