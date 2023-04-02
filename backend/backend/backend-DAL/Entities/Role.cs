using Microsoft.AspNetCore.Identity;

namespace backend.backend_DAL.Entities
{
    public class Role : IdentityRole<string>
    {
        public virtual ICollection<UserRole> UserRole { get; set; }
    }
}
