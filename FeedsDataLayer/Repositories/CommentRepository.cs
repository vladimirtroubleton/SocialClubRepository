using FeedsDataLayer.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FeedsDataLayer.Repositories
{
    public class CommentRepository : ICommentRepository
    {
        private FeedsContext context;
        object glush = new object();
        public CommentRepository(FeedsContext context)
        {
            this.context = context;
        }

        public async Task CreateComment(CommentModel comment)
        {
            lock (glush)
            {
                context.Comments.Add(comment);
            };
            await context.SaveChangesAsync();
        }

        public async Task RemoveComment(CommentModel comment)
        {
            lock (glush)
            {
                context.Comments.Remove(comment);
            };
            await context.SaveChangesAsync();
        }

        public async Task<CommentModel> GetCommentById(int id)
        {
            return await context.Comments.FindAsync(id);
        }
        public Task<List<CommentModel>> GetCommentsByGroup(Guid idGroup)
        {
            return Task.FromResult(context.Comments.Where(x => x.GroupId == idGroup).ToList());
        }

    }
}
