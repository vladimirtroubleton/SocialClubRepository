using AuthDataLayer.Models;
using AuthDataLayer.ViewModels;

namespace AuthDataLayer.ModelBuilders
{
    public interface IUsersModelBuilder
    {
        UserModel GetUserModelByUserView(UserViewModel viewModel);
    }
}