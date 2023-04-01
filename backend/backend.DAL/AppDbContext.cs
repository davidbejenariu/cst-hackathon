using blood_donation_backend.blood_donation_backend.DAL.Entities;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;

namespace backend.backend.DAL
{
    public class AppDbContext : IdentityDbContext<AppUser, IdentityRole, string>
    {


    }

}