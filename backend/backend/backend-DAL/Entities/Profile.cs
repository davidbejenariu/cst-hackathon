namespace backend.backend_DAL.Entities
{
    public class Profile
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string? PhoneNumber { get; set; }
        public DateTime? BirthDate { get; set; }
        public int? Points { get; set; }
        public int? Streak { get; set; }
        public string? Image { get; set; }

        public string UserId { get; set; }
        public virtual User? User { get; set; }

        public int PartnerId { get; set; }
        public virtual Partner? Partner { get; set; }

        public virtual IEnumerable<ProfileOffer>? ProfileOffers { get; set; }
        public virtual IEnumerable<SurveyAnswer>? SurveyAnswers { get; set; }
    }
}
