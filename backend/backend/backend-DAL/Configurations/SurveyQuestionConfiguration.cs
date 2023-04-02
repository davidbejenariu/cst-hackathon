using backend.backend_DAL.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace backend.backend_DAL.Configurations
{
    public class SurveyQuestionConfiguration : IEntityTypeConfiguration<SurveyQuestion>
    {
        public void Configure(EntityTypeBuilder<SurveyQuestion> builder)
        {
            builder.HasKey(x => x.Id);

            builder.Property(x => x.Question)
                .HasColumnType("nvarchar(1000)")
                .IsRequired(true);

            builder.HasOne(x => x.Survey)
                .WithMany(x => x.Questions)
                .HasForeignKey(x => x.SurveyId);
        }
    }
}
