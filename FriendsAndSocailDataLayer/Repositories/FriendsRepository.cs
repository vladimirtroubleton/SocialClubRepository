using FriendsAndSocailDataLayer.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FriendsAndSocailDataLayer.Repositories
{
    public class FriendsRepository : IFriendsRepository
    {
        SocialContext context;

        public FriendsRepository(SocialContext context)
        {
            this.context = context;
        }

        object locker = new object();

        public async Task CreateFriendRecord(FriendsModel friend)
        {
            lock (locker)
            {
                context.Friends.Add(friend);
            }
            await context.SaveChangesAsync();
        }
        public Task<string[]> GetFriendsLoginsByUserLogin(string login)
        {
            return Task.FromResult(context.Friends.Where(x => x.CurrentUserLogin == login).Select(x => x.FriendUserLogin).ToArray());
        }

        public async Task RemoveFriend(FriendsModel friend)
        {
            lock (locker)
            {
                context.Friends.Remove(friend);
            }
            await context.SaveChangesAsync();
        }
    }
}
