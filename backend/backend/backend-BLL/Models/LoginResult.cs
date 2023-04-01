namespace backend.backend_BLL.Models
{
    public class LoginResult
    {
        public bool Success { get; set; }
        public string AccessToken { get; set; }

        public string RefreshToken { get; set; }
    }
}
