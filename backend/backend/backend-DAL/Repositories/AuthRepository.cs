using backend.backend_DAL.Entities;
using backend.backend_DAL.Interfaces;
using Microsoft.AspNetCore.Identity;

namespace backend.backend_DAL.Repositories
{
    public class AuthRepository : IAuthRepository
    {
        private readonly UserManager<User> _userManager;

        public AuthRepository(UserManager<User> userManager)
        {
            _userManager = userManager;
        }
    }
}
