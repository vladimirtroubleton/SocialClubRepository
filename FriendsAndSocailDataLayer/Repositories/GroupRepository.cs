using FriendsAndSocailDataLayer.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FriendsAndSocailDataLayer.Repositories
{
    public class GroupRepository : IGroupRepository
    {
        SocialContext context;

        public GroupRepository(SocialContext context)
        {
            this.context = context;
        }

        object locker = new object();

        public async Task CreateGroup(GroupModel group)
        {
            lock (locker)
            {
                context.Groups.Add(group);
            }
            await context.SaveChangesAsync();
        }

        public async Task DeleteGroup(GroupModel group)
        {
            lock (locker)
            {
                context.Groups.Remove(group);
            }
            await context.SaveChangesAsync();

            var connects = await GetGroupConnectByGroupId(group.Id);
            foreach (var item in connects)
            {
                await RemoveGroupConnect(item);
            }
        }

        public Task<GroupModel[]> GetGroups()
        {
            return Task.FromResult(context.Groups.ToArray());
        }

        public Task<GroupModel> GetGroupById(int id)
        {
            return Task.FromResult(context.Groups.Find(id));
        }

        public async Task CreateGroupConnect(int groupId, string userLogin)
        {
            lock (locker)
            {
                context.GroupConnects.Add(new GroupConnect { GroupId = groupId, UserLogin = userLogin });
            }
            await context.SaveChangesAsync();
        }

        public async Task RemoveGroupConnect(GroupConnect groupConnect)
        {
            lock (locker)
            {
                context.GroupConnects.Remove(groupConnect);
            }
            await context.SaveChangesAsync();
        }

        public Task<GroupConnect[]> GetGroupConnectByGroupId(int id)
        {
            return Task.FromResult(context.GroupConnects.Where(x => x.GroupId == id).ToArray());
        }
        public Task<GroupConnect[]> GetGroupConnectByUserLogin(string login)
        {
            return Task.FromResult(context.GroupConnects.Where(x => x.UserLogin == login).ToArray());
        }

    }
}
