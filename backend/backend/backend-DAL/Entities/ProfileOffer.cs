using System.ComponentModel.DataAnnotations.Schema;

namespace backend.backend_DAL.Entities
{
    public class ProfileOffer
    {

        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public Guid? ProfileOfferId { get; set; }
        public Guid? ProfileId { get; set; }
        public Profile? Profile { get; set; }
        public Guid? OfferId { get; set; }
        public Offer? Offer { get; set; }
    }
}
