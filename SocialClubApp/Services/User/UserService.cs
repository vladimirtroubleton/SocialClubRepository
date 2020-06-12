using AuthDataLayer.Models;
using AuthDataLayer.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SocialClubApp.Services
{
    public class UserService
    {
        private readonly IUsersRepository usersRepository;

        public UserService(IUsersRepository usersRepository)
        {
            this.usersRepository = usersRepository;
        }

        public bool CheckLogin(string login)
        {
            return usersRepository.CheckLogin(login);
        }

        public async Task<UserModel> GetCurrentUser(string login)
        {
            return await usersRepository.GetUserByLogin(login);
        } 
        public async Task<UserModel[]> GetUsers(string login)
        {

             var allUsers = await usersRepository.GetAllUsers();
            return allUsers.Where(x=> x.Login!=login).ToArray();
        }
    }
}
