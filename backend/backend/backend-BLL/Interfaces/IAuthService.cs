using backend.backend_BLL.Models;

namespace backend.backend_BLL.Interfaces
{
    public interface IAuthService
    {
        Task Register(RegisterModel registerModel);
        Task<LoginResult> Login(LoginModel loginModel);
    }
}
