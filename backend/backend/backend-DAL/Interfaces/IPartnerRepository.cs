using backend.backend_DAL.Entities;

namespace backend.backend_DAL.Interfaces
{
    public interface IPartnerRepository
    {
        Task Create(Partner partner);
        Task<List<Partner>> GetAllPartners();
        Task<Partner> GetById(string id);
    }
}
