using backend.backend_DAL.Entities;

namespace backend.backend_DAL.Interfaces
{
    public interface ICodeRepository
    {
        Task Create(Code code);
        Task<List<Code>> GetAllCodes();
    }
}