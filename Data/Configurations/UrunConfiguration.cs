using Demo1.Model;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System.Reflection.Emit;

namespace Demo1.Data.Configurations
{
    public class UrunConfiguration : IEntityTypeConfiguration<Urun>
    {
        public void Configure(EntityTypeBuilder<Urun> builder)
        {
            builder.HasKey(u => u.Id);
            builder.HasIndex(u => u.Id);
            builder.Property(c => c.UrunAdi).IsRequired().HasMaxLength(70);

            //--------------------------------

            builder.HasOne(u => u.Kategori)
                .WithMany(k => k.Urunler) 
                .HasForeignKey(u => u.KategoriID);

            builder.HasOne(k => k.Marka)
                .WithMany(u => u.Urunler)
                .HasForeignKey(k=>k.MarkaID);

            builder.HasMany(fd => fd.FisDestekler)
                .WithOne(u => u.Urun)
                .HasForeignKey(fd => fd.UrunID);

        

            builder.HasMany(du => du.DepoUrunleri)
                .WithOne(u => u.Urun)
                .HasForeignKey(du => du.UrunID);
        }

    }
}
