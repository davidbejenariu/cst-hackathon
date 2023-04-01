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
        public Guid? SurveyId { get; set; }
        public Survey? Survey { get; set; }

        // 1 - 1: Offer - Product
        public Guid? ProductId { get; set; }

        public Product? Product { get; set; }

        // M - 1: Offer - Partner

        public Guid? PartnerId { get; set; }
        public Partner? Partner { get; set; }

        //M-M Profile-Offer
        public IList<ProfileOffer>? ProfileOffers { get; set; }
    }
}
