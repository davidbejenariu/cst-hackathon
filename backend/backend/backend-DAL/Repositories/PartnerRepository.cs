using backend.backend_DAL.Entities;
using backend.backend_DAL.Interfaces;

namespace backend.backend_DAL.Repositories
{
    public class PartnerRepository : IPartnerRepository
    {
        private readonly AppDbContext _db;

        public PartnerRepository(AppDbContext db)
        {
            _db = db;
        }

        public async Task Create(Partner partner)
        {
            await _db.Partners.AddAsync(partner);
            await _db.SaveChangesAsync();
        }

        public async Task<List<Partner>> GetAllPartners()
        {
            var partners = _db.Partners.ToList();
            return partners;
        }

        public async Task<Partner> GetById(int id)
        {
            return _db.Partners.FirstOrDefault(x => x.Id == id);

        }
    }
}
