using backend.backend_DAL.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace backend.backend_DAL.Configurations
{
    public class ProfileConfiguration : IEntityTypeConfiguration<Profile>
    {
        public void Configure(EntityTypeBuilder<Profile> builder)
        {
            builder.HasKey(x => x.Id);

            builder.Property(x => x.FirstName)
                .HasColumnType("nvarchar(50)")
                .IsRequired(true);

            builder.Property(x => x.LastName)
                .HasColumnType("nvarchar(50)")
                .IsRequired(true);

            builder.Property(x => x.PhoneNumber)
                .HasColumnType("nvarchar(20)")
                .IsRequired(false);

            builder.Property(x => x.BirthDate)
                .HasColumnType("datetime")
                .IsRequired(false);

            builder.Property(x => x.Points)
                .HasColumnType("int")
                .IsRequired(false);
            
            builder.Property(x => x.Streak)
                .HasColumnType("int")
                .IsRequired(false);

            builder.Property(x => x.Image)
                .HasColumnType("nvarchar(100)")
                .IsRequired(false);

            builder.Property(x => x.PartnerId)
                .IsRequired(false);

            builder.HasOne(x => x.User)
                .WithOne(x => x.Profile)
                .HasForeignKey<Profile>(x => x.UserId);

            builder.HasOne(x => x.Partner)
                .WithMany(x => x.Profiles)
                .HasForeignKey(x => x.PartnerId)
                .IsRequired(false);
        }
    }
}
