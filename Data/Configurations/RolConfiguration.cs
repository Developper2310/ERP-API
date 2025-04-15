using Demo1.Model;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;

namespace Demo1.Data.Configurations
{
    public class RolConfiguration : IEntityTypeConfiguration<Rol>
    {
        public void Configure(EntityTypeBuilder<Rol> builder)
        {
            builder.HasKey(r => r.Id);
            builder.Property(r => r.RolAdi).IsRequired().HasMaxLength(50);


            builder.HasMany(r => r.KullaniciRolleri)
                .WithOne(kr => kr.Rol)
                .HasForeignKey(kr => kr.RolID);

            builder.HasMany(r => r.RolYetkileri)
                .WithOne(ry => ry.Rol)
                .HasForeignKey(ry => ry.RolID);
        }
    }
}
