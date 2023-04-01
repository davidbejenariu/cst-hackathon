using backend.backend_DAL.Entities;
using System.Security.Claims;

namespace backend.backend_BLL.Interfaces
{
    public interface ITokenHelper
    {
        Task<String> CreateAccessToken(User _User);
        string CreateRefreshToken(User _User);
        ClaimsPrincipal GetPrincipalFromRefreshToken(string _Token);
    }
}
