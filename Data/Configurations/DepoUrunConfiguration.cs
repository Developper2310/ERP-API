using Demo1.Model;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;

namespace Demo1.Data.Configurations
{
    public class DepoUrunConfiguration: IEntityTypeConfiguration<DepoUrun>
    {
        public void Configure(EntityTypeBuilder<DepoUrun> builder)//HASNAME KULLANIMINDA KAFAM KARIŞTI BURASI BEKLEMEDE
        {
            builder.HasKey(du => new { du.UrunID, du.DepoId });//composite pk


            builder.HasOne(du => du.Depo)
               .WithMany(d => d.DepoUrunleri)
               .HasForeignKey(du => du.DepoId)
               .OnDelete(DeleteBehavior.Cascade); 

            
            builder.HasOne(du => du.Urun)
                .WithMany(u => u.DepoUrunleri)
                .HasForeignKey(du => du.UrunID)
                .OnDelete(DeleteBehavior.Cascade);



        }
    
    }
}
