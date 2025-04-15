using Demo1.Model;
using Microsoft.AspNetCore.DataProtection;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Demo1.Data.Configurations
{
    public class AlimSatimConfiguration : IEntityTypeConfiguration<AlimSatim>
    {
        public void Configure(EntityTypeBuilder<AlimSatim> builder)
        {
            builder.HasKey(als => als.Id);

           // builder.Property(p=>p.Id).ValueGeneratedOnAdd();

            builder.HasOne(a => a.Calisan)
             .WithMany(c => c.AlimSatimlar)
             .HasForeignKey(a => a.CalisanID)
             ;


            builder.HasMany(f => f.FisDestekler)
                .WithOne(a=>a.AlimSatim)
                .HasForeignKey(f => f.AlimSatimID);




            builder.HasOne(a => a.Depo)
    .WithMany(u => u.AlimSatimlar)
    .HasForeignKey(a => a.DepoID);

        }
    }
}
