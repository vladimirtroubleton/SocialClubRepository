using AuthDataLayer.Models;
using AuthDataLayer.Repositories;
using AuthDataLayer.ViewModels;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace AuthDataLayer.Utils
{
    public class LoginUtil : ILoginUtil
    {
        private readonly IUsersRepository usersRepository;
        private readonly IPasswordHash passwordHash;

        public LoginUtil(IUsersRepository usersRepository, IPasswordHash passwordHash)
        {
            this.usersRepository = usersRepository;
            this.passwordHash = passwordHash;
        }

        public async  Task<UserModel> CheckUserDataByLoginViewModel(LoginViewModel loginModel)
        {
            var loggingUser = await usersRepository.GetUserByLogin(loginModel.Login);
            
            if (loggingUser == null) return null;
            loginModel.Password = passwordHash.GetHash(loginModel.Password);
            if (loggingUser.Password == loginModel.Password)
            {
                return loggingUser;
            }
            else
            {
                return null;
            }
        }
    }
}
