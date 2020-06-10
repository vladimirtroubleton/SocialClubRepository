using AuthDataLayer.Models;
using System;
using System.Threading.Tasks;

namespace AuthDataLayer.Repositories
{
    public interface IUsersRepository
    {
        Task AddUser(UserModel user);
        Task<UserModel> EditUser(UserModel user);
        Task<UserModel[]> GetAllUsers();
        Task<UserModel> GetUserByLogin(string login);
        Task RemoveUser(UserModel user);
        bool CheckLogin(string login);
        
    }
}