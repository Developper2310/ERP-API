using Demo1.Model;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;

namespace Demo1.Data.Configurations
{
    public class MarkaConfiguration : IEntityTypeConfiguration<Marka>
    {
        public void Configure(EntityTypeBuilder<Marka> builder)
        {
            builder.HasKey(a => a.Id);
            builder.Property(c => c.MarkaAdi).IsRequired().HasMaxLength(70);

            builder.HasMany(a => a.Urunler)
                .WithOne(p => p.Marka)
                .HasForeignKey(a => a.MarkaID);
        }
    }
}
