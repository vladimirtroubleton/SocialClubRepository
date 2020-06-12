using FeedsDataLayer.Models;
using FeedsDataLayer.Repositories;
using FilesManageDataLayer.Models;
using FilesManageDataLayer.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SocialClubApp.Services
{
    public class FeedsService
    {
        private readonly IFeedsRepository feedsRepository;
        private readonly IFilesRepository filesRepository;

        public FeedsService(IFeedsRepository feedsRepository, IFilesRepository filesRepository)
        {
            this.feedsRepository = feedsRepository;
            this.filesRepository = filesRepository;
        }

        public async Task CreateFeed(FeedModel feedModel)
        {
            await feedsRepository.CreateFeed(feedModel);
        }

        public async Task<FeedModel[]> GetFeedsByUserLogin(string login)
        {
            return await feedsRepository.GetFeedsByLogin(login);
        }


        public async Task<FilesByFeeds[]> GetConnectionsFiles(Guid idFeed)
        {
            return await filesRepository.GetConnectionsfilesByFeedId(idFeed);
        }
        
    }
}
