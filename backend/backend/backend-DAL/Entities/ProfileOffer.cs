namespace backend.backend_DAL.Entities
{
    public class ProfileOffer
    {
        public string Id { get; set; }
        public bool IsRedeemed { get; set; }

        public string ProfileId { get; set; }
        public virtual Profile? Profile { get; set; }

        public string OfferId { get; set; }
        public virtual Offer? Offer { get; set; }
    }
}
