namespace backend.backend_DAL.Entities
{
    public class Offer
    {
        public int Id { get; set; }

        public DateTime CreationDate { get; set; }
        public DateTime? StartDate { get; set; }
        public DateTime? EndDate { get; set; }

        public decimal CarbonFootprint { get; set; }
        public bool IsActive { get; set; }
        public string Image { get; set; }

        // 1 - 1: Offer - Survey
        public virtual Survey Survey { get; set; }

        // 1 - 1: Offer - Product
        public virtual Product Product { get; set; }

        // M - 1: Offer - Partner
        public int PartnerId { get; set; }
        public virtual Partner? Partner { get; set; }

        //M-M Profile-Offer
        public virtual IEnumerable<ProfileOffer>? ProfileOffers { get; set; }
    }
}
