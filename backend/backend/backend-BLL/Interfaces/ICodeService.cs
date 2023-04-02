using backend.backend_BLL.Models;

namespace backend.backend_BLL.Interfaces
{
        public interface ICodeService
        {
            Task Create(CodeModel code);
            Task<List<Guid>> GetCodes();
        }
}