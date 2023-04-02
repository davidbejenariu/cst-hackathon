namespace backend.backend_DAL.Entities
{
    public class Partner
    {
        public int Id { get; set; }
        public string? Name { get; set; }
        public string? Website { get; set; }
        public string? Image { get; set; }

        // 1 - M : Partner - User
        public virtual IEnumerable<Profile>? Profiles { get; set; }

        // 1 - M : Partner - Offer
        public virtual IEnumerable<Offer>? Offers { get; set; }
    }
}
