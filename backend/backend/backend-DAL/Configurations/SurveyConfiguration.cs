using backend.backend_DAL.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace backend.backend_DAL.Configurations
{
    public class SurveyConfiguration : IEntityTypeConfiguration<Survey>
    {
        public void Configure(EntityTypeBuilder<Survey> builder)
        {
            builder.HasKey(x => x.Id);

            builder.Property(x => x.OfferId)
                .IsRequired(false);

            builder.HasOne(x => x.Offer)
                .WithOne(x => x.Survey)
                .HasForeignKey<Survey>(x => x.OfferId);
        }
    }
}
