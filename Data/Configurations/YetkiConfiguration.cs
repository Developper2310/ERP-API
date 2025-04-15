using Demo1.Model;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;

namespace Demo1.Data.Configurations
{
    public class YetkiConfiguration : IEntityTypeConfiguration<Yetki>
    {
        public void Configure(EntityTypeBuilder<Yetki> builder)
        {
            builder.HasKey(y => y.Id);
            builder.Property(y => y.YetkiAdi).IsRequired().HasMaxLength(100);
            builder.Property(y => y.Aciklama).HasMaxLength(255);

            builder.HasMany(y => y.RolYetkileri)
                .WithOne(ry => ry.Yetki)
                .HasForeignKey(y=>y.YetkiID);

        }
    }
}
