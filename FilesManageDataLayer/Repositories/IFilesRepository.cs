using FilesManageDataLayer.Models;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace FilesManageDataLayer.Repositories
{
    public interface IFilesRepository
    {
        Task<FileModel> CreateNewFile(string name, string path);
        Task DeleteFile(FileModel fileModel);
        Task<FileModel> GetFileById(int id);
        Task<FileModel[]> CreateNewFiles(Dictionary<string, string> filesDict);
        Task CreateNewConnectionRecord(FilesByFeeds filesByFeeds);
        Task<FilesByFeeds[]> GetConnectionsfilesByFeedId(Guid feedId);
    }
}