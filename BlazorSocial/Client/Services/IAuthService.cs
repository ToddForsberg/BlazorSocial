using System.Threading.Tasks;
using BlazorSocial.Shared.IdentityModels;

namespace BlazorSocial.Client.Services
{
    public interface IAuthService
    {
        Task<RegisterResult> Register(RegisterModel registerModel);
        Task<LoginResult> Login(LoginModel loginModel);
        Task Logout();
    }
}