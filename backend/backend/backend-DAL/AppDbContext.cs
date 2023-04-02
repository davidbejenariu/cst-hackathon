﻿using backend.backend_DAL.Configurations;
using backend.backend_DAL.Entities;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace backend.backend_DAL
{
    public class AppDbContext : IdentityDbContext<
        User, 
        Role, 
        string,
        IdentityUserClaim<string>,
        UserRole,
        IdentityUserLogin<string>, 
        IdentityRoleClaim<string>,
        IdentityUserToken<string>>
        //User, Role, string>
    {
        public DbSet<Code> Codes { get; set; }
        public DbSet<Offer> Offers { get; set; }
        public DbSet<Partner> Partners { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<ProfileOffer> ProfileOffers { get; set; }
        public DbSet<Survey> Surveys { get; set; }
        public DbSet<UserRefreshToken> RefreshTokens { get; set; }
        public DbSet<Profile> Profiles { get; set; }
        public DbSet<SurveyQuestion> SurveyQuestions { get; set; }
        public DbSet<SurveyQuestion> SurveyAnswers { get; set; }

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

            modelBuilder.Entity<UserRole>()
                .HasOne<User>(x => x.User)
                .WithOne().HasForeignKey<UserRole>(x => x.UserId)
                .OnDelete(DeleteBehavior.NoAction);

            modelBuilder.Entity<UserRole>()
                .HasOne<Role>(x => x.Role)
                .WithOne().HasForeignKey<UserRole>(x => x.UserId)
                .OnDelete(DeleteBehavior.NoAction);

            modelBuilder.ApplyConfiguration(new CodeConfiguration());
            modelBuilder.ApplyConfiguration(new OfferConfiguration());
            modelBuilder.ApplyConfiguration(new PartnerConfiguration());
            modelBuilder.ApplyConfiguration(new ProductConfiguration());
            modelBuilder.ApplyConfiguration(new ProfileConfiguration());
            modelBuilder.ApplyConfiguration(new ProfileOfferConfiguration());
            modelBuilder.ApplyConfiguration(new SurveyConfiguration());
            modelBuilder.ApplyConfiguration(new SurveyAnswerConfiguration());
            modelBuilder.ApplyConfiguration(new SurveyQuestionConfiguration());
        }
    }
}
