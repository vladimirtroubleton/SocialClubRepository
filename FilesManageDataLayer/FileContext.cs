using FilesManageDataLayer.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace FilesManageDataLayer
{
    public class FileContext : DbContext
    {
        public DbSet<FileModel> Files { get; set; }
        public DbSet<FilesByFeeds> FilesСonnection { get; set; }
        public FileContext(DbContextOptions<FileContext> options) : base(options)
        {
            Database.EnsureCreated();
        }
    }
}
