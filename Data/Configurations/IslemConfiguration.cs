using Demo1.Model;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;

namespace Demo1.Data.Configurations
{
    public class IslemConfiguration : IEntityTypeConfiguration<Islem>
    {
        public void Configure(EntityTypeBuilder<Islem> builder)
        {

         
            builder.HasKey(i => i.Id)
                ;
            builder.Property(i => i.IslemAdi).IsRequired().HasMaxLength(100);

            builder.HasMany(i => i.KullaniciIslemleri)
                .WithOne(ki => ki.Islem)
                .HasForeignKey(i=>i.IslemID);

        }
    }
}
