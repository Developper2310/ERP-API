using Demo1.Model;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;

namespace Demo1.Data.Configurations
{
    public class RolYetkiConfiguration : IEntityTypeConfiguration<RolYetki>
    {
        public void Configure(EntityTypeBuilder<RolYetki> builder)
        {
            builder.HasKey(ry => ry.Id);

            builder.HasOne(r => r.Rol)
                .WithMany(ry => ry.RolYetkileri)
                .HasForeignKey(ry => ry.RolID);


            builder.HasOne(ry => ry.Yetki)
                .WithMany(r=>r.RolYetkileri)
                .HasForeignKey(ry => ry.YetkiID);

        }
    }
}
