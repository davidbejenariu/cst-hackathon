namespace backend.backend_DAL.Entities
{
    public class SurveyAnswer
    {
        public int Id { get; set; }
        public string Answer { get; set; }

        // M - M: User - SurveyQuestion
        public int QuestionId { get; set; }
        public virtual SurveyQuestion? Question { get; set; }
        public int ProfileId { get; set; }
        public virtual Profile? Profile { get; set; }
    }
}
