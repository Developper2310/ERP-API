using Demo1.Model;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;

namespace Demo1.Data.Configurations
{
    public class DepoConfiguration : IEntityTypeConfiguration<Depo>
    {
        public void Configure(EntityTypeBuilder<Depo> builder)
        { 
            builder.HasKey(a => a.Id);





            builder.Property(c => c.DepoAdi).IsRequired().HasMaxLength(100);
            builder.Property(c => c.Adres).IsRequired().HasMaxLength(300);
            builder.Property(c => c.Telefon).IsRequired().HasMaxLength(13);

            builder.Property(d => d.DepoAdi)
                .IsRequired()
                .HasMaxLength(100);


          

            builder.HasMany(d => d.DepoUrunleri)
                .WithOne(d => d.Depo)
                .HasForeignKey(d => d.DepoId);

            builder.HasMany(d => d.AlimSatimlar)
               .WithOne(d => d.Depo)
               .HasForeignKey(d => d.Id);

        }
    }
}
