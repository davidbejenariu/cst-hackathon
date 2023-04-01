using System.ComponentModel.DataAnnotations;

namespace backend.backend_DAL.Entities
{
    public class UserRefreshToken
    {
        public Guid Id { get; set; }
        public string UserId { get; set; }
        public User User { get; set; }

        [Required]
        public string RefreshToken { get; set; }
    }
}
