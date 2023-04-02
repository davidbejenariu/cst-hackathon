namespace backend.backend_DAL.Entities
{
    public class Partner
    {
        public int Id { get; set; }
       
        public string? Name { get; set; }
        public string? Website { get; set; }
        public string? Image { get; set; }

        // 1 - 1 : Partner - User
        public string UserId { get; set; }
        public virtual User User { get; set; }

        // 1 - M : Partener - Offer
        public virtual ICollection<Offer>? Offers { get; set; }
    }
}
