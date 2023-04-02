using backend.backend_DAL.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace backend.backend_DAL.Configurations
{
    public class ProfileOfferConfiguration : IEntityTypeConfiguration<ProfileOffer>
    {
        public void Configure(EntityTypeBuilder<ProfileOffer> builder)
        {
            builder.HasKey(x => x.Id);

            builder.Property(x => x.IsRedeemed)
                .HasColumnType("bit")
                .HasDefaultValue(false);

            builder.HasOne(x => x.Profile)
                .WithMany(x => x.ProfileOffers)
                .HasForeignKey(x => x.ProfileId);

            builder.HasOne(x => x.Offer)
                .WithMany(x => x.ProfileOffers)
                .HasForeignKey(x => x.OfferId);
        }
    }
}
