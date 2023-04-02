using backend.backend_BLL.Models;
using backend.backend_DAL.Entities;

namespace backend.backend_DAL.Interfaces
{
    public interface IOfferRepository
    {
        Task CreateOffer(OfferModel model);
        Task<List<OfferViewModel>> GetAll(string profileId);
        Task CreateProduct(string offerId, ProductModel model);
        Task CreateSurveyQuestion(string surveyId, SurveyQuestionModel model);
        Task CreateSurvey(string offerId, SurveyModel model);
        Task<SurveyModel> GetSurvey(string surveyId);
    }
}
