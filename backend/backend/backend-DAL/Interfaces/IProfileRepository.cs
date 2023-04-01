using backend.backend_DAL.Entities;

namespace backend.backend_DAL.Interfaces
{
    public interface IProfileRepository
    {
        Task CreateProfile(Profile profile);
    }
}
