using Demo1.Model;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

public class DepartmanConfiguration : IEntityTypeConfiguration<Departman>
{
    public void Configure(EntityTypeBuilder<Departman> builder)
    {
        //pk
        builder.HasKey(d => d.Id).HasName("Id");

        //
        builder.Property(d => d.DepartmanAdi)
            .IsRequired()
            .HasMaxLength(100);


        //relations
        builder.HasMany(c => c.Calisanlar)
            .WithOne(dh=>dh.Departman)
            .HasForeignKey(c=>c.DepartmanID);

       
    }
}
