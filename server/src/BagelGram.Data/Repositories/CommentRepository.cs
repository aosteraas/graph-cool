using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BagelGram.Core.Interfaces;
using BagelGram.Core.Models;
using Microsoft.EntityFrameworkCore;

namespace BagelGram.Data.Repositories
{
    public class CommentRepository : ICommentRepository
    {
        private readonly BagelContext _context;

        public CommentRepository(BagelContext context)
        {
            _context = context;
        }

        public async Task<Comment> CreateCommentAsync(Comment comment)
        {
            var newComment = new Comment
            {
                ImageId = comment.ImageId,
                UserId = comment.UserId,
                Text = comment.Text
            };
            await _context.AddAsync(newComment);
            await _context.SaveChangesAsync();
            return newComment;
        }

        public async Task<IList<Comment>> GetImageComments(int imageId) => await _context
            .Comments
            .AsNoTracking()
            .Where(x => x.ImageId == imageId)
            .ToListAsync();

        public async Task<IList<Comment>> GetUserComments(int userId) => await _context
            .Comments
            .AsNoTracking()
            .Where(x => x.UserId == userId)
            .ToListAsync();
    }
}