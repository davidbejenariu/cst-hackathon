using backend.backend_BLL.Models;
using backend.backend_DAL.Interfaces;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace backend.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class OfferController : ControllerBase
    {
        private readonly IOfferRepository _repo;

        public OfferController(IOfferRepository repo)
        {
            _repo = repo;
        }

        [HttpPost("AddOffer")]
        public async Task<IActionResult> AddOffer([FromBody] OfferModel model)
        {
            if (model == null)
            {
                throw new ArgumentNullException("model");
            }

            await _repo.CreateOffer(model);
            return Ok("Offer added");
        }

        [HttpPost("AddProduct/{offerId}")]
        public async Task<IActionResult> AddProduct([FromRoute] string offerId,
            [FromBody] ProductModel model)
        {
            if (model == null)
            {
                throw new ArgumentNullException("model");
            }

            await _repo.CreateProduct(offerId, model);
            return Ok("Product added");
        }

        [HttpPost("AddSurvey/{offerId}")]
        public async Task<IActionResult> AddSurvey([FromRoute] string offerId,
            [FromBody] SurveyModel model)
        {
            if (model == null)
            {
                throw new ArgumentNullException("model");
            }

            await _repo.CreateSurvey(offerId, model);
            return Ok("Survey added");
        }

        [HttpPost("AddSurveyQuestion/{surveyId}")]
        public async Task<IActionResult> AddSurveyQuestion([FromRoute] string surveyId,
            [FromBody] SurveyQuestionModel model)
        {
            if (model == null)
            {
                throw new ArgumentNullException("model");
            }

            await _repo.CreateSurveyQuestion(surveyId, model);
            return Ok("Survey question added");
        }

        [HttpGet("GetOffers/{profileId}")]
        public async Task<IActionResult> GetOffers([FromRoute] string profileId)
        {
            var offers = _repo.GetAll(profileId);
            return Ok(offers);
        }

        [HttpGet("GetSurvey/{surveyId}")]
        public async Task<IActionResult> GetSurvey([FromRoute] string surveyId)
        {
            var survey = _repo.GetSurvey(surveyId);
            return Ok(survey);
        }
    }
}
