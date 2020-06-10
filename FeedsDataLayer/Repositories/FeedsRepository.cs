using FeedsDataLayer.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FeedsDataLayer.Repositories
{
    public class FeedsRepository : IFeedsRepository
    {
        private FeedsContext context;
        object glush = new object();
        public FeedsRepository(FeedsContext context)
        {
            this.context = context;
        }

        public async Task CreateFeed(FeedModel feedModel)
        {
            lock (glush)
            {
                context.Feeds.Add(feedModel);
            };
            await context.SaveChangesAsync();
        }

        public Task<FeedModel[]> GetAllFeeds()
        {
            return Task.FromResult(context.Feeds.ToArray());
        }

        public async Task RemoveFeed(FeedModel feedModel)
        {
            lock (glush)
            {
                context.Feeds.Remove(feedModel);
            }
            await context.SaveChangesAsync();

        }

        public async Task UpdateFeed(FeedModel feedModel)
        {
            lock (glush)
            {
                context.Feeds.Update(feedModel);
            }
            await context.SaveChangesAsync();

        }

        public async Task<FeedModel> GetFeedById(Guid id)
        {
            return await context.Feeds.FindAsync(id);
        }

        public async Task<FeedModel[]> GetFeedsByLogin(string login)
        {
            return await context.Feeds.Where(x => x.Author == login).ToArrayAsync();
        }
    }
}
