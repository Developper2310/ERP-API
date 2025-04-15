using Demo1.Model;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Demo1.Data.Configurations
{
    public class KategoriConfiguration : IEntityTypeConfiguration<Kategori>
    {
        public void Configure(EntityTypeBuilder<Kategori> builder)
        {
            builder.Property(i => i.KategoriAdi).IsRequired().HasMaxLength(100);
            builder.HasKey(k => k.Id);


            builder.HasMany(k => k.Urunler) 
               .WithOne(u => u.Kategori) 
               .HasForeignKey(u => u.KategoriID);
    
        }
    }
}
