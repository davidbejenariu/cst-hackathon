using Microsoft.AspNetCore.Identity;

namespace backend.backend_DAL.Entities
{
    public class User : IdentityUser
    {
        public DateTime TokenExpiration { get; set; }
        public List<UserRefreshToken> RefreshTokens { get; set; }
    }
}
