using backend.backend_DAL.Entities;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace backend.backend_DAL
{
    public class AppDbContext : IdentityDbContext<User, IdentityRole, string>
    {
        public DbSet<Code> Codes { get; set; }
        public DbSet<Offer> Offers { get; set; }
        public DbSet<Partner> Partners { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<ProfileOffer> ProfileOffers { get; set; }
        public DbSet<Survey> Surveys { get; set; }

        public DbSet<UserRefreshToken> RefreshTokens { get; set; }
        public DbSet<Profile> Profiles { get; set; }

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

            modelBuilder.Entity<Profile>()
                    .HasOne(d => d.User)
                    .WithOne(au => au.Profile)
                    .HasForeignKey<Profile>(d => d.UserId)
                    .OnDelete(DeleteBehavior.NoAction);
            modelBuilder.Entity<Partner>()
                     .HasOne(d => d.User)
                     .WithOne(au => au.Partner)
                     .HasForeignKey<Partner>(d => d.UserId)
                     .OnDelete(DeleteBehavior.NoAction);

            modelBuilder.Entity<Product>()
                .HasOne<Offer>(p => p.Offer)
                .WithOne(t => t.Product)
                .HasForeignKey<Offer>(t => t.ProductId);

            modelBuilder.Entity<Survey>()
                .HasOne<Offer>(p => p.Offer)
                .WithOne(t => t.Survey)
                .HasForeignKey<Offer>(t => t.SurveyId);

            /* modelBuilder.Entity<Offer>()
                       .HasOne<Donor>(p => p.Donor)
                       .WithMany(d => d.Patients)
                       .HasForeignKey(p => p.CurrentDonorId)
                       .OnDelete(DeleteBehavior.Cascade);*/

            modelBuilder.Entity<ProfileOffer>().HasKey(pm => new { pm.ProfileId, pm.OfferId });

            modelBuilder.Entity<ProfileOffer>()
                .HasOne<Profile>(pm => pm.Profile)
                .WithMany(p => p.ProfileOffers)
                .HasForeignKey(pm => pm.ProfileId)
                .OnDelete(DeleteBehavior.Cascade);


            modelBuilder.Entity<ProfileOffer>()
                .HasOne<Offer>(pm => pm.Offer)
                .WithMany(p => p.ProfileOffers)
                .HasForeignKey(pm => pm.OfferId)
                .OnDelete(DeleteBehavior.Cascade);

            modelBuilder.Entity<Offer>()
               .HasOne<Partner>(p => p.Partner)
               .WithMany(d => d.Offers)
               .HasForeignKey(p => p.PartnerId)
               .OnDelete(DeleteBehavior.Cascade);

            modelBuilder.Entity<Code>()
               .HasOne<Product>(p => p.Product)
               .WithMany(d => d.Codes)
               .HasForeignKey(p => p.ProductId)
               .OnDelete(DeleteBehavior.Cascade);


        }

    }
}
