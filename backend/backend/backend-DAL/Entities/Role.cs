using Microsoft.AspNetCore.Identity;

namespace backend.backend_DAL.Entities
{
    public class Role : IdentityRole<string>
    {
        public string Name { get; set; }
    }
}
