namespace backend.backend_DAL.Entities
{
    public class Offer
    {
        public Guid Id { get; set; }

        public DateTime CreationDate { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public float? CarbonFootprint { get; set; }

        public bool isActive { get; set; }
        public string Image { get; set; }

        // 1 - 1: Offer - Survey
        public string SurveyId { get; set; }
        public Survey Survey { get; set; }

        // 1 - 1: Offer - Product
        public string ProductId { get; set; }

        public Product Product { get; set; }

        // M - 1: Offer - Partner

        public string PartnerId { get; set; }

    }
}
