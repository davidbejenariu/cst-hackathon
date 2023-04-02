namespace backend.backend_DAL.Entities
{
    public class SurveyAnswer
    {
        public string Id { get; set; }
        public string Answer { get; set; }

        // M - M: User - SurveyQuestion
        public string QuestionId { get; set; }
        public virtual SurveyQuestion? Question { get; set; }
        public string ProfileId { get; set; }
        public virtual Profile? Profile { get; set; }
    }
}
