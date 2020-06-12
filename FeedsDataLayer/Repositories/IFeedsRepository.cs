using FeedsDataLayer.Models;
using System;
using System.Threading.Tasks;

namespace FeedsDataLayer.Repositories
{
    public interface IFeedsRepository
    {
        Task CreateFeed(FeedModel feedModel);
        Task<FeedModel[]> GetAllFeeds();
        Task<FeedModel> GetFeedById(Guid id);
        Task RemoveFeed(FeedModel feedModel);
        Task UpdateFeed(FeedModel feedModel);
        Task<FeedModel[]> GetFeedsByLogin(string login);
    }
}