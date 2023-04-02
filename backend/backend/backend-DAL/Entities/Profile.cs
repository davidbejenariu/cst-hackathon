namespace backend.backend_DAL.Entities
{
    public class Profile
    {
        public Guid Id { get; set; }
        public string? FirstName { get; set; }
        public string? LastName { get; set; }
        public string? PhoneNumber { get; set; }
        public string? EmailAddress { get; set; }
        public DateTime? BirthDate { get; set; }


        public long? Points { get; set; }
        public long? Streak { get; set; }
        public string? Image { get; set; }

        public int PartnerId { get; set; }
        public virtual Partner Partner { get; set; }
        public virtual string UserId { get; set; }
        public virtual User User { get; set; }

        public IList<ProfileOffer>? ProfileOffers { get; set; }
    }
}
