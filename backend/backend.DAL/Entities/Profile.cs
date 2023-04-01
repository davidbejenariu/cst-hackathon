using blood_donation_backend.blood_donation_backend.DAL.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace backend.DAL.Entities
{
    public class Profile
    {
        public Guid ProfileId { get; set; }
        [StringLength(70)]
        public string? FirstName { get; set; }

        [StringLength(70)]
        public string? LastName { get; set; }

        public string? Email { get; set; }

        [Range(0, 100)]
        public int Age { get; set; }

        public string? Gender { get; set; }

        public string? PhoneNumber { get; set; }


        public virtual string UserId { get; set; }
        public virtual AppUser User { get; set; }
    }
}
