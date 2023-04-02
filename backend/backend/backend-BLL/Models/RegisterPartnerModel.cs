using System.ComponentModel.DataAnnotations;

namespace backend.backend_BLL.Models
{
    public class Accounts
    {
        public string Email { get; set; }
        public string Password { get; set; }
    }
    public class RegisterPartnerModel
    {
        [Required]
        public string FirstName { get; set; }
        [Required]
        public string LastName { get; set; }

        public List<Accounts> accountList = new List<Accounts>();
        
        
        /*public RegisterPartners() { 
        accountList.Add(new Accounts { Email = "foo", Password = "bar" });
        accountList.Add(new Accounts { Email = "hello", Password = "world" });
        }*/
    }
}
