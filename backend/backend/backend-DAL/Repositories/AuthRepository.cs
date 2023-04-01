using backend.backend_DAL.Entities;
using backend.backend_DAL.Interfaces;
using Microsoft.AspNetCore.Identity;

namespace backend.backend_DAL.Repositories
{
    public class AuthRepository : IAuthRepository
    {
        private readonly UserManager<User> _userManager;
        private readonly AppDbContext _appDbContext;

        public AuthRepository(UserManager<User> userManager, AppDbContext appDbContext)
        {
            _userManager = userManager;
            _appDbContext = appDbContext;
        }

      

     
    }
}
