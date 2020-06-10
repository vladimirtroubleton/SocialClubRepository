using AuthDataLayer.ResultModels;
using AuthDataLayer.ViewModels;
using Blazored.LocalStorage;
using BlazorInputFile;
using FeedsDataLayer.Models;
using FilesManageDataLayer.Models;
using FilesManageDataLayer.Repositories;
using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Authorization;
using Microsoft.AspNetCore.Hosting;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace SocialClubApp.Services
{
    public class FilesService
    {
        private readonly IWebHostEnvironment _environment;
        private readonly HttpClient httpClient;
        private readonly IFilesRepository filesRepository;

        public FilesService(IWebHostEnvironment environment, HttpClient httpClient, IFilesRepository filesRepository)
        {
            _environment = environment;
            this.httpClient = httpClient;
            this.filesRepository = filesRepository;
        }

        public async Task<FileModel> CreateFile(IFileListEntry fileEntry )
        {
                var path = Path.Combine("Files","Photos",fileEntry.Name);
                var ms = new MemoryStream();
                var pathInSrtream = _environment.WebRootPath +"\\"+ path;
                await fileEntry.Data.CopyToAsync(ms);
                using (FileStream file = new FileStream(pathInSrtream, FileMode.Create, FileAccess.Write))
                {
                    ms.WriteTo(file);
                }
                var result = await filesRepository.CreateNewFile(fileEntry.Name, path);
                return result;

        }

        public async Task<FileModel[]> CreateFiles(IFileListEntry[] filesEntry)
        {
            Dictionary<string, string> filesDataDict = new Dictionary<string, string>();

            foreach (var fileEntry in filesEntry) 
            { 
                var path = Path.Combine("Files", "Photos", fileEntry.Name);
                var ms = new MemoryStream();
                var pathInSrtream = _environment.WebRootPath + "\\" + path;
                await fileEntry.Data.CopyToAsync(ms);
                using (FileStream file = new FileStream(pathInSrtream, FileMode.Create, FileAccess.Write))
                {
                    ms.WriteTo(file);
                }
                filesDataDict.Add(fileEntry.Name, path);
            }
            var result = await filesRepository.CreateNewFiles(filesDataDict);
            return result;

        }

        public async Task AddFilesConnection(Guid idFeed , FileModel[] files)
        {
            foreach (var item in files)
            {
              await filesRepository.CreateNewConnectionRecord(new FilesByFeeds { FeedId = idFeed, FileId = item .Id});
            }
        }
        public async Task AddFileConnection(Guid idFeed , FileModel file)
        {
            await filesRepository.CreateNewConnectionRecord(new FilesByFeeds { FeedId = idFeed, FileId = file.Id });
        }

        public async Task<FileModel[]> GetConnectionsFileByFeed(Guid feedId)
        {
          List<FileModel> filesList = new List<FileModel>(); 

          var connections = await filesRepository.GetConnectionsfilesByFeedId(feedId);

          foreach(var i in connections.Select(x=> x.FileId))
          {
                filesList.Add(await filesRepository.GetFileById(i)) ;
          }
            return filesList.ToArray();
        }
    }
}
