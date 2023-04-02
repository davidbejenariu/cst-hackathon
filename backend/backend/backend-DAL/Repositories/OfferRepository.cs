using backend.backend_BLL.Models;
using backend.backend_DAL.Entities;
using backend.backend_DAL.Interfaces;
using Microsoft.EntityFrameworkCore;
using System;

namespace backend.backend_DAL.Repositories
{
    public class OfferRepository : IOfferRepository
    {
        private readonly AppDbContext _context;

        public OfferRepository(AppDbContext context) 
        { 
            this._context = context;
        }
        
        public async Task CreateOffer(OfferModel model)
        {
            var offer = new Offer
            {
                CarbonFootprint = model.CarbonFootprint,
                IsActive = false,
                Image = model.Image,
                PartnerId = model.PartnerId
            };

            await _context.Offers.AddAsync(offer);
            await _context.SaveChangesAsync();
        }

        public async Task<List<OfferViewModel>> GetAll(string profileId)
        {
            var userOffers = await _context
                .ProfileOffers
                .Where(x => x.ProfileId == profileId)
                .ToListAsync();

            return await _context
                .Offers
                .Join(userOffers, b => b.Id, a => a.OfferId, (b, a) => new OfferViewModel
                {
                    CarbonFootprint = b.CarbonFootprint,
                    Image = b.Image,
                    CompanyName = b.Partner.Name,
                    Product = new ProductModel
                    {
                        Name = b.Product.Name,
                        Image = b.Product.Image
                    },
                    IsRedeemed = a.IsRedeemed,
                    SurveyId = b.Survey.Id
                })
                .ToListAsync();
        }

        public async Task CreateProduct(string offerId, ProductModel model)
        {
            var product = new Product
            {
                Name = model.Name,
                Image = model.Image,
                OfferId = offerId
            };

            await _context.Products.AddAsync(product);
            await _context.SaveChangesAsync();
        }

        public async Task CreateSurveyQuestion(string surveyId, SurveyQuestionModel model)
        {
            var surveyQuestion = new SurveyQuestion
            {
                SurveyId = surveyId,
                Question = model.Question
            };

            await _context.SurveyQuestions.AddAsync(surveyQuestion);
            await _context.SaveChangesAsync();
        }

        public async Task CreateSurvey(string offerId, SurveyModel model)
        {
            var survey = new Survey
            {
                OfferId = offerId,
                Questions = model.SurveyQuestions
            };

            await _context.Surveys.AddAsync(survey);
            await _context.SaveChangesAsync();
        }

        public async Task<SurveyModel> GetSurvey(string surveyId)
        {
            return await _context
                .Surveys
                .Where(x => x.Id == surveyId)
                .Select(x => new SurveyModel
                {
                    SurveyQuestions = x.Questions
                })
                .FirstOrDefaultAsync();
        }
    }
}
