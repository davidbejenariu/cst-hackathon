using backend.backend_DAL.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace backend.backend_DAL.Configurations
{
    public class CodeConfiguration : IEntityTypeConfiguration<Code>
    {
        public void Configure(EntityTypeBuilder<Code> builder)
        {
            builder.HasKey(x => x.Id);

            builder.Property(x => x.Content)
                .HasColumnType("nvarchar(100)")
                .IsRequired(true);

            builder.Property(x => x.IsUsed)
                .HasColumnType("bit")
                .HasDefaultValue(false);

            builder.HasOne(p => p.Product)
                .WithMany(p => p.Codes)
                .HasForeignKey(p => p.ProductId);
        }
    }
}
