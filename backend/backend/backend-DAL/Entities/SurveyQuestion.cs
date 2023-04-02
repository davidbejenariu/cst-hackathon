using System.Text.Json;

namespace backend.backend_DAL.Entities
{
    public class SurveyQuestion
    {
        public string Id { get; set; }
        public string Question { get; set; }

        public string SurveyId { get; set; }
        public virtual Survey? Survey { get; set; }

        public virtual IEnumerable<SurveyAnswer>? Answers { get; set; }
    }
}
