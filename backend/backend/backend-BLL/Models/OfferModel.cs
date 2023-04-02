using backend.backend_DAL.Entities;

namespace backend.backend_BLL.Models
{
    public class OfferModel
    {
        public decimal CarbonFootprint { get; set; }
        public string Image { get; set; }
        public string PartnerId { get; set; }
    }
}
