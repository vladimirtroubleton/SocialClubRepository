using FriendsAndSocailDataLayer.Models;
using System.Threading.Tasks;

namespace FriendsAndSocailDataLayer.Repositories
{
    public interface IFriendsRepository
    {
        Task CreateFriendRecord(FriendsModel friend);
        Task<string[]> GetFriendsLoginsByUserLogin(string login);
        Task RemoveFriend(FriendsModel friend);
    }
}