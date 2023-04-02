using backend.backend_DAL.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace backend.backend_DAL.Configurations
{
    public class ProductConfiguration : IEntityTypeConfiguration<Product>
    {
        public void Configure(EntityTypeBuilder<Product> builder)
        {
            builder.HasKey(x => x.Id);

            builder.Property(x => x.Name)
                .HasColumnType("nvarchar(100)")
                .IsRequired(true);

            builder.Property(x => x.Image)
                .HasColumnType("nvarchar(100)")
                .IsRequired(true);

            builder.Property(x => x.OfferId)
                .IsRequired(false);

            builder.HasOne(x => x.Offer)
                .WithOne(x => x.Product)
                .HasForeignKey<Product>(x => x.OfferId);
        }
    }
}
