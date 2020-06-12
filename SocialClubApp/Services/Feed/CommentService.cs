using FeedsDataLayer.Models;
using FeedsDataLayer.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SocialClubApp.Services.Feed
{
    public class CommentService
    {
        public ICommentRepository commentRepository;

        public CommentService(ICommentRepository commentRepository)
        {
            this.commentRepository = commentRepository;
        }

        public async Task CreateComment(CommentModel comment)
        {
            await commentRepository.CreateComment(comment);
        }


        public async Task RemoveComment(CommentModel comment)
        {
            await commentRepository.RemoveComment(comment);
        }

        public async Task<CommentModel> GetCommentById(int id)
        {
           return await commentRepository.GetCommentById(id);
        }

        public async Task<List<CommentModel>> GetCommentByGroupId(Guid id)
        {
            return await commentRepository.GetCommentsByGroup(id);
        }

    }
}
