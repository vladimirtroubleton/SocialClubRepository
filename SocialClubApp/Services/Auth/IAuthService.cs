using AuthDataLayer.ResultModels;
using AuthDataLayer.ViewModels;
using System.Threading.Tasks;

namespace SocialClubApp.Services
{
    public interface IAuthService
    {
        Task<LoginResult> Login(LoginViewModel loginModel);
        Task Logout();
        Task<RegisterResult> Register(UserViewModel registerModel);
    }
}