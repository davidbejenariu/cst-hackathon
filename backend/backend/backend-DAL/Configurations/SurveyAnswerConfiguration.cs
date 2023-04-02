using backend.backend_DAL.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace backend.backend_DAL.Configurations
{
    public class SurveyAnswerConfiguration : IEntityTypeConfiguration<SurveyAnswer>
    {
        public void Configure(EntityTypeBuilder<SurveyAnswer> builder)
        {
            builder.HasKey(x => x.Id);

            builder.Property(x => x.Answer)
                .HasColumnType("nvarchar(1000)")
                .IsRequired(true);

            builder.HasOne(x => x.Question)
                .WithMany(x => x.Answers)
                .HasForeignKey(x => x.QuestionId);

            builder.HasOne(x => x.Profile)
                .WithMany(x => x.SurveyAnswers)
                .HasForeignKey(x => x.ProfileId);
        }
    }
}
