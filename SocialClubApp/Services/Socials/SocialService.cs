using AuthDataLayer.Models;
using AuthDataLayer.Repositories;
using FriendsAndSocailDataLayer.Models;
using FriendsAndSocailDataLayer.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SocialClubApp.Services.Socials
{
    public class SocialService
    {
        private readonly IFriendsRepository friendsRepository;
        private readonly IGroupRepository groupRepository;
        private readonly IUsersRepository usersRepository;

        public SocialService(IFriendsRepository friendsRepository, IGroupRepository groupRepository, IUsersRepository usersRepository)
        {
            this.friendsRepository = friendsRepository;
            this.groupRepository = groupRepository;
            this.usersRepository = usersRepository;
        }

        public async Task<string[]> GetFriendsLoginArray(UserModel currentUser)
        {
            
            return await friendsRepository.GetFriendsLoginsByUserLogin(currentUser.Login);
          
        }

        public async Task<List<UserModel>> GetFriendsByLoginsArray(UserModel currentUser ,string[] friendLogins)
        {
            List<UserModel> friends = new List<UserModel>();
           
            foreach (var friendLogin in friendLogins)
            {
                friends.Add( await usersRepository.GetUserByLogin(friendLogin));
            }
            return friends;
        }

        public async Task AddFriend(UserModel currentUser , string friendLogin)
        {
            await friendsRepository.CreateFriendRecord(new FriendsModel { CurrentUserLogin = currentUser.Login , FriendUserLogin = friendLogin });
        }

        public async Task<GroupConnect[]> GetGroupIdsByUser(UserModel currentUser)
        {
            var conn = await groupRepository.GetGroupConnectByUserLogin(currentUser.Login);
            return conn;

        }
        public async Task<GroupModel[]> GetGroupsByIds(GroupConnect[] connectModel)
        {
            List<GroupModel> groupModels = new List<GroupModel>();
            foreach (var item in connectModel)
            {
                groupModels.Add(await groupRepository.GetGroupById(item.GroupId));
            }

            return groupModels.ToArray();

        }

        public async Task<GroupModel[]> GetAllGroups()
        {
            return await groupRepository.GetGroups();
        }

        public async Task CreateGroup(GroupModel groupModel)
        {
            groupModel.CountUsersInGroup = 1;
            await groupRepository.CreateGroup(groupModel);
        }

        public async Task<GroupModel[]> GetGroupsByConnectRecords(GroupConnect[] connects)
        {
            List<GroupModel> groupModels = new List<GroupModel>();
            foreach(var connect in connects)
            {
                groupModels.Add(await groupRepository.GetGroupById(connect.GroupId));
            }
            return groupModels.ToArray();
        }

        public async Task CreateGroupConnect(int id, UserModel user)
        {
            await groupRepository.CreateGroupConnect(id , user.Login);
        }
    }
}
