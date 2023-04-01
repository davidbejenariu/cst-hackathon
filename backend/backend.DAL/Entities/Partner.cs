using blood_donation_backend.blood_donation_backend.DAL.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace backend.DAL.Entities
{
    public class Partner
    {
        public Guid PartnerId { get; set; }

        public string? PartnerName { get; set; }
        public string? Email { get; set; }
        public string? PhoneNumber { get; set; }
        public virtual string UserId { get; set; }
        public virtual AppUser User { get; set; }

        public ICollection<Offer>? Offers { get; set; }
    }
}
