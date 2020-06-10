using AuthDataLayer.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AuthDataLayer.Repositories
{
    public class UsersRepository : IUsersRepository
    {
        UserContext context;
        public UsersRepository(UserContext context)
        {
            this.context = context;
        }

        public async Task AddUser(UserModel user)
        {
            await context.Users.AddAsync(user);
            await context.SaveChangesAsync();
        }

        public async Task<UserModel> EditUser(UserModel user)
        {
            context.Entry(user).State = EntityState.Modified;
            await context.SaveChangesAsync();
            return user;
        }

        public async Task RemoveUser(UserModel user)
        {
            context.Users.Remove(user);
            await context.SaveChangesAsync();
        }

        public async Task<UserModel[]> GetAllUsers()
        {
            return await context.Users.ToArrayAsync();
        }

        public async Task<UserModel> GetUserByLogin(string login)
        {
            return await context.Users.FindAsync(login);
        }

      

        public bool CheckLogin(string login)
        {
            return context.Users.Select(x=> x.Login).Contains(login);
        }
    }
}
