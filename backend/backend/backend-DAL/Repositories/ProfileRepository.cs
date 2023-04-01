using backend.backend_DAL.Entities;
using backend.backend_DAL.Interfaces;

namespace backend.backend_DAL.Repositories
{
    public class ProfileRepository : IProfileRepository
    {
        private readonly AppDbContext _appDbContext;

        public ProfileRepository(AppDbContext appDbContext)
        {
            
            _appDbContext = appDbContext;
        }
        public async Task CreateProfile(Profile profile)
        {
            await _appDbContext.Profiles.AddAsync(profile);
            await _appDbContext.SaveChangesAsync();
        }
    }
}
