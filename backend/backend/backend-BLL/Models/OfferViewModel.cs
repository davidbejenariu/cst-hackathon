namespace backend.backend_BLL.Models
{
    public class OfferViewModel
    {
        public decimal CarbonFootprint { get; set; }
        public string Image { get; set; }
        public string CompanyName { get; set; }
        public ProductModel Product { get; set; }
        public bool IsRedeemed { get; set; }
        public string SurveyId { get; set; }
    }
}
