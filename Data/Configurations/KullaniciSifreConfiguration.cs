using Demo1.Model;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;

namespace Demo1.Data.Configurations
{
    public class KullaniciSifreConfiguration : IEntityTypeConfiguration<KullaniciSifre>
    {
        public void Configure(EntityTypeBuilder<KullaniciSifre> builder)
        {

            builder.HasKey(s => s.Id);
            builder.Property(s => s.Sifre).IsRequired();
            builder.Property(s => s.OlusturmaTarihi).IsRequired();
            builder.Property(s => s.Aktif).IsRequired();


            builder.HasOne(ks => ks.Calisan)
                .WithMany(s => s.KullaniciSifreleri)
                .HasForeignKey(ks => ks.CalisanID);

        }
    }
}
