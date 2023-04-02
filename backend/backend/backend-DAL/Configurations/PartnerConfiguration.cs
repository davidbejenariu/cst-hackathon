using backend.backend_DAL.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace backend.backend_DAL.Configurations
{
    public class PartnerConfiguration : IEntityTypeConfiguration<Partner>
    {
        public void Configure(EntityTypeBuilder<Partner> builder)
        {
            builder.HasKey(x => x.Id);

            builder.Property(x => x.Name)
                .HasColumnType("nvarchar(50)")
                .IsRequired(true);

            builder.Property(x => x.Website)
                .HasColumnType("nvarchar(100)")
                .IsRequired(true);

            builder.Property(x => x.Image)
                .HasColumnType("nvarchar(100)")
                .IsRequired(false);
        }
    }
}
