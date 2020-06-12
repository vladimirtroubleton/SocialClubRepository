using FeedsDataLayer.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace FeedsDataLayer
{
    public class FeedsContext : DbContext
    {
        public DbSet<FeedModel> Feeds { get; set; }
        public FeedsContext(DbContextOptions<FeedsContext> options):base(options)
        {
            Database.EnsureCreated();
        }
    }
}
