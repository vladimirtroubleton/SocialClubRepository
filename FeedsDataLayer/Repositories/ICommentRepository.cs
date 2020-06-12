using FeedsDataLayer.Models;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace FeedsDataLayer.Repositories
{
    public interface ICommentRepository
    {
        Task CreateComment(CommentModel comment);
        Task<CommentModel> GetCommentById(int id);
        Task<List<CommentModel>> GetCommentsByGroup(Guid idGroup);
        Task RemoveComment(CommentModel comment);
    }
}