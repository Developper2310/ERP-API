using Demo1.Model;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;

namespace Demo1.Data.Configurations
{
    public class KullaniciRolConfiguration : IEntityTypeConfiguration<KullaniciRol>
    {
        public void Configure(EntityTypeBuilder<KullaniciRol> builder)
        {
            builder.HasKey(du => new { du.RolID, du.CalisanID });

            builder.HasOne(kr => kr.Calisan)
                .WithMany(c => c.KullaniciRolleri)
                .HasForeignKey(kr => kr.CalisanID);

            builder.HasOne(kr => kr.Rol)
                .WithMany(r => r.KullaniciRolleri)
                .HasForeignKey(kr => kr.RolID);

        }
    }
}
