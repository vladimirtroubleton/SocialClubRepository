using FriendsAndSocailDataLayer.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace FriendsAndSocailDataLayer
{
    public class SocialContext : DbContext
    {
        public DbSet<FriendsModel> Friends { get; set; }
        public DbSet<GroupModel> Groups { get; set; }
        public DbSet<GroupConnect> GroupConnects { get; set; }

        public SocialContext(DbContextOptions<SocialContext> options) : base(options)
        {
            Database.EnsureCreated();
        }
    }
}
