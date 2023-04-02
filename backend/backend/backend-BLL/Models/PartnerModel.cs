using System.ComponentModel.DataAnnotations;

namespace backend.backend_BLL.Models
{
    public class PartnerModel
    {
       
        public string? Name { get; set; }
        public string? Website { get; set; }
        public string? Image { get; set; }
        public List<string>? UserId { get; set; }

    }
}
