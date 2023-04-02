using backend.backend_BLL.Interfaces;
using backend.backend_BLL.Models;
using backend.backend_DAL.Entities;
using backend.backend_DAL.Interfaces;
using Microsoft.AspNetCore.Identity;

namespace backend.backend_BLL.Services
{
    public class PartnerService : IPartnerService
    {
       
        private readonly IPartnerRepository _partnerRepository;
        private readonly UserManager<User> _userManager;
        private readonly IProfileRepository _profileRepository;


        public PartnerService(IPartnerRepository partnerRepository, UserManager<User> userManager, IProfileRepository profileRepository)
        {
            
            _partnerRepository = partnerRepository;
            _userManager = userManager;
            _profileRepository = profileRepository;
        }

        public async Task Create(PartnerModel partner)
        {
            var newPartner = new Partner
            {
                Name = partner.Name,
                Website = partner.Website,
                Image = partner.Image
            };
            await _partnerRepository.Create(newPartner);

        }
        public async Task<List<PartnerModel>> GetPartners()
        {
            var partners = await _partnerRepository.GetAllPartners();
            var list = new List<PartnerModel>();
            foreach (var partner in partners)
            {
                PartnerModel partnerModel = new PartnerModel
                {
                    Name = partner.Name,
                    Website = partner.Website,
                    Image = partner.Image,
                };
                list.Add(partnerModel);
            }
            return list;

        }

        public async Task RegisterPartner(string id, RegisterModel registerModel)
        {
            var user = new User
            {
                Email = registerModel.Email,
                UserName = registerModel.Email
            };
            var result = await _userManager.CreateAsync(user, registerModel.Password);
            var profile = new Profile
            {
                FirstName = registerModel.FirstName,
                LastName = registerModel.LastName,
                UserId = user.Id,
                PartnerId = id
            };
            await _profileRepository.CreateProfile(profile);


            if (result.Succeeded)
            {
                await _userManager.AddToRoleAsync(user, "Partner");

                //await SaveChangesAsync();

                /*  SmtpClient smtpClient = new SmtpClient("smtp.gmail.com", 587);

                  smtpClient.Credentials = new System.Net.NetworkCredential("blooddonationtest@gmail.com", "nvfayjhmcruemsvf");
                  // smtpClient.UseDefaultCredentials = true; // uncomment if you don't want to use the network credentials
                  smtpClient.DeliveryMethod = SmtpDeliveryMethod.Network;
                  smtpClient.EnableSsl = true;
                  MailMessage mail = new MailMessage();
                  mail.Subject = "Thank you for register";
                  mail.Body = "<p>Hello,</p><br><p>Welcome to Blood-Donation-Platform</p>";
                  mail.IsBodyHtml = true;
                  //Setting From , To and CC
                  mail.From = new MailAddress("blooddonationtest@gmail.com", "MyWeb Site");
                  mail.To.Add(new MailAddress(profile.EmailAddress));*/
                //mail.CC.Add(new MailAddress("MyEmailID@gmail.com"));

                //smtpClient.Send(mail);
            }
            else
            {
                throw new Exception(String.Join(",", result.Errors.Select(x => x.Code)));
            }

        }
    }

}

