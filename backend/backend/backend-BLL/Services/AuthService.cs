using backend.backend_BLL.Interfaces;
using backend.backend_BLL.Models;
using backend.backend_DAL.Entities;
using Microsoft.AspNetCore.Identity;

namespace backend.backend_BLL.Services
{
    public class AuthService : IAuthService
    {
        /*private readonly UserManager<User> _userManager;
        private readonly SignInManager<User> _signInManager;
        private readonly ITokenHelper _tokenHelper;

        public AuthService(UserManager<User> userManager,
                            SignInManager<User> signInManager,
                            ITokenHelper tokenHelper)
        {
            _userManager = userManager;
            _signInManager = signInManager;
            _tokenHelper = tokenHelper;
        }




        public async Task<LoginResult> Login(LoginModel loginModel)
        {
            var user = await _userManager.FindByEmailAsync(loginModel.Email);
            if (user == null)
                return new LoginResult
                {
                    Success = false

                };
            else
            {
                var result = await _signInManager.CheckPasswordSignInAsync(user, loginModel.Password, false);
                if (result.Succeeded)
                {
                    var token = await _tokenHelper.CreateAccessToken(user);
                    var refreshToken = _tokenHelper.CreateRefreshToken(user);

                    return new LoginResult
                    {
                        Success = true,
                        AccessToken = token,
                        RefreshToken = refreshToken

                    };
                }
                else
                    return new LoginResult
                    {
                        Success = false
                    };
            }

        }
        public async Task Register(RegisterModel registerModel)
        {
            var user = new User
            {
                Email = registerModel.Email,
                UserName = registerModel.Email

            };
            var result = await _userManager.CreateAsync(user, registerModel.Password);

            if (result.Succeeded)
            {
                await _userManager.AddToRoleAsync(user, "BasicUser");
                

                await SaveChangesAsync();

                SmtpClient smtpClient = new SmtpClient("smtp.gmail.com", 587);

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
                mail.To.Add(new MailAddress("blooddonationtest@gmail.com"));
                //mail.CC.Add(new MailAddress("MyEmailID@gmail.com"));

                smtpClient.Send(mail);
            }
            else
            {
                throw new Exception(String.Join(",", result.Errors.Select(x => x.Code)));
            }

        }*/
    }
}

