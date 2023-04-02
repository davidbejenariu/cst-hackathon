using backend.backend_DAL.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace backend.backend_DAL.Configurations
{
    public class OfferConfiguration : IEntityTypeConfiguration<Offer>
    {
        public void Configure(EntityTypeBuilder<Offer> builder)
        {
            builder.HasKey(x => x.Id);

            builder.Property(x => x.CreationDate)
                .HasColumnType("datetime")
                .HasDefaultValue(DateTime.UtcNow);

            builder.Property(x => x.StartDate)
                .HasColumnType("datetime");

            builder.Property(x => x.EndDate)
                .HasColumnType("datetime");

            builder.Property(x => x.CarbonFootprint)
                .HasColumnType("decimal(8, 2)")
                .IsRequired(true);

            builder.Property(x => x.IsActive)
                .HasColumnType("bit")
                .HasDefaultValue(false);

            builder.Property(x => x.Image)
                .HasColumnType("nvarchar(100)")
                .IsRequired(false);

            builder.HasOne(x => x.Partner)
                .WithMany(x => x.Offers)
                .HasForeignKey(x => x.PartnerId);
        }
    }
}
