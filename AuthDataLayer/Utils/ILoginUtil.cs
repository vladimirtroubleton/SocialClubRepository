using AuthDataLayer.Models;
using AuthDataLayer.ViewModels;
using System.Threading.Tasks;

namespace AuthDataLayer.Utils
{
    public interface ILoginUtil
    {
        Task<UserModel> CheckUserDataByLoginViewModel(LoginViewModel loginModel);
    }
}