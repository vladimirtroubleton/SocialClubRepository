using AuthDataLayer.Models;
using AuthDataLayer.ViewModels;
using System;
using System.Collections.Generic;
using System.Text;

namespace AuthDataLayer.ModelBuilders
{
    public class UsersModelBuilder : IUsersModelBuilder
    {
        public UserModel GetUserModelByUserView(UserViewModel viewModel)
        {
            return new UserModel
            {
                Login = viewModel.Login,
                Age = int.Parse(viewModel.Age),
                Email = viewModel.Email,
                Password = viewModel.Password,
                Name = viewModel.Name,
                Surname = viewModel.Surname,
                AvatarPath = viewModel.AvatarPath

            };
        }
    }
}
