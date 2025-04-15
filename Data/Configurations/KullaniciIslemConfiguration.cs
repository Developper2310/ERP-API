using Demo1.Model;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;

namespace Demo1.Data.Configurations
{
    public class KullaniciIslemConfiguration : IEntityTypeConfiguration<KullaniciIslem>
    {
        public void Configure(EntityTypeBuilder<KullaniciIslem> builder)
        {
           
            builder.HasKey(i => i.Id);
            builder.Property(i => i.IslemTarihi).IsRequired();

            builder.HasOne(ki => ki.Islem)
                .WithMany(i => i.KullaniciIslemleri)
                .HasForeignKey(ki=>ki.IslemID);

            builder.HasOne(ki => ki.Calisan)
                .WithMany(c=>c.KullaniciIslemleri)
                .HasForeignKey(ki=>ki.CalisanID);

        }
    }
}
