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
        //protected override void OnModelCreating(ModelBuilder modelBuilder)
        //{
        //    modelBuilder.Entity<UserModel>().HasData(new UserModel[] { new UserModel { Surname = test , } });
        //    base.OnModelCreating(modelBuilder);
        //}
    }
}
