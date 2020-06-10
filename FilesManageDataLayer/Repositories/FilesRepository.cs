using FilesManageDataLayer.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FilesManageDataLayer.Repositories
{

    public class FilesRepository : IFilesRepository
    {
        private FileContext context;
       

        public FilesRepository(FileContext context)
        {
            this.context = context;
        }

        private object locker = new object();

        public async Task<FileModel> GetFileById(int id)
        {
            return await context.Files.FindAsync(id);
            
        }

        public async Task<FileModel> CreateNewFile(string name , string path)
        {
            lock (locker)
            {
                context.Files.Add(new FileModel {Name = name, Path = path });
            }
            await context.SaveChangesAsync();
            return context.Files.Where(x => x.Name == name).FirstOrDefault();
        }

        public  Task<FileModel[]> CreateNewFiles(Dictionary<string,string> filesDict)
        {
            List<FileModel> filesList = new List<FileModel>();
            foreach (var item in filesDict)
            {
                filesList.Add(new FileModel {Name = item.Key, Path = item.Value });
            }
            lock (locker)
            {
                 context.Files.AddRange(filesList);
            }
             context.SaveChanges();

            var keys = filesList.Select(x => x.Id).ToArray();

            var countList = filesList.Count();

            FileModel[] filesArray= new FileModel[countList];

            for( int i = 0; i< countList; i++)
            {
                filesArray[i] = context.Files.Find(keys[i]);
            }
            return Task.FromResult( filesArray);
            
        }

        public async Task DeleteFile(FileModel fileModel)
        {
            lock (locker)
            {
                context.Files.Remove(fileModel);
            }
            await context.SaveChangesAsync();
        }

        public async Task CreateNewConnectionRecord(FilesByFeeds filesByFeeds)
        {
            lock (locker)
            {
                context.FilesСonnection.Add(filesByFeeds);
            }
            await context.SaveChangesAsync();
            
        }

        public Task<FilesByFeeds[]> GetConnectionsfilesByFeedId(Guid feedId)
        {
           return Task.FromResult( context.FilesСonnection.Where(x=> x.FeedId == feedId).ToArray());
        }
    }
}
