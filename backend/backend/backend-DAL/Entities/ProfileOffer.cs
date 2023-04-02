namespace backend.backend_DAL.Entities
{
    public class ProfileOffer
    {
        public int Id { get; set; }
        public bool IsRedeemed { get; set; }

        public int ProfileId { get; set; }
        public virtual Profile? Profile { get; set; }

        public int OfferId { get; set; }
        public virtual Offer? Offer { get; set; }
    }
}
