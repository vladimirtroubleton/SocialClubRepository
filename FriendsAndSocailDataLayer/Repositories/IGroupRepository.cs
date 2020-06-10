using FriendsAndSocailDataLayer.Models;
using System.Threading.Tasks;

namespace FriendsAndSocailDataLayer.Repositories
{
    public interface IGroupRepository
    {
        Task CreateGroup(GroupModel group);
        Task CreateGroupConnect(int groupId, string userLogin);
        Task DeleteGroup(GroupModel group);
        Task<GroupModel> GetGroupById(int id);
        Task<GroupConnect[]> GetGroupConnectByGroupId(int id);
        Task<GroupConnect[]> GetGroupConnectByUserLogin(string login);
        Task<GroupModel[]> GetGroups();
        Task RemoveGroupConnect(GroupConnect groupConnect);
    }
}