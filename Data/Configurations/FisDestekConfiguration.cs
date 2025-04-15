using Demo1.Model;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;

namespace Demo1.Data.Configurations
{
    public class FisDestekConfiguration : IEntityTypeConfiguration<FisDestek>
    {
        public void Configure(EntityTypeBuilder<FisDestek> builder)
        {
            builder.HasKey(du => new { du.UrunID, du.AlimSatimID});


            builder.HasOne(fd => fd.AlimSatim)
                .WithMany(f => f.FisDestekler)
                .HasForeignKey(f => f.AlimSatimID);

            builder.HasOne(fd => fd.Urun)
                .WithMany(u => u.FisDestekler)
                .HasForeignKey(fd=>fd.UrunID);
        }
    
    }
}
