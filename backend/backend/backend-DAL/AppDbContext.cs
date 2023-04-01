using backend.backend_DAL.Entities;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace backend.backend_DAL
{
    public class AppDbContext : IdentityDbContext<User, IdentityRole, string>
    {
        public DbSet<UserRefreshToken> RefreshTokens { get; set; }
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<UserRefreshToken>()
                   .HasOne(d => d.User)
                   .WithMany(au => au.RefreshTokens)
                   .HasForeignKey(d => d.UserId)
                   .OnDelete(DeleteBehavior.Cascade);
        }

    }
}
