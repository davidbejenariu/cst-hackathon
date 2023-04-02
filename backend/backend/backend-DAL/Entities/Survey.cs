namespace backend.backend_DAL.Entities
{
    public class Survey
    {
        public string Id { get; set; }

        // 1 - 1: Offer - Survey
        public string OfferId { get; set; }
        public virtual Offer? Offer { get; set; }

        // 1 - M: Survey - SurveyQuestion
        public virtual List<SurveyQuestion>? Questions { get; set; }        
    }
}
