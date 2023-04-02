using backend.backend_BLL.Models;

namespace backend.backend_BLL.Interfaces
{
    public interface IPartnerService
    {
        Task Create(PartnerModel partner);
        Task<List<PartnerModel>> GetPartners();
        Task RegisterPartner(string id, RegisterModel registerModel);
    }
}
