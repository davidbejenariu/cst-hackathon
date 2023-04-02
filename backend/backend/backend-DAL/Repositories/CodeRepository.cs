using backend.backend_DAL.Entities;
using backend.backend_DAL.Interfaces;

namespace backend.backend_DAL.Repositories
{
    public class CodeRepository : ICodeRepository
    {
        private readonly AppDbContext _db;

        public CodeRepository(AppDbContext db)
        {
            _db = db;
        }
        public async Task Create(Code code)
        {
            await _db.Codes.AddAsync(code);
            await _db.SaveChangesAsync();
        }
        public async Task<List<Code>> GetAllCodes()
        {
            var codes = _db.Codes
            .ToList();
            return codes;
        }
    }
}