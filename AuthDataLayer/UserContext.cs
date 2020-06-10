using AuthDataLayer.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace AuthDataLayer
{
    public class UserContext : DbContext
    {
        public DbSet<UserModel> Users { get; set; }
        public UserContext(DbContextOptions<UserContext> options) : base(options)
        {
            Database.EnsureCreated();
        }
     
    }
}
