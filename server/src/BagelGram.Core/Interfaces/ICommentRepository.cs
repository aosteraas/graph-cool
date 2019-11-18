using System.Collections.Generic;
using System.Threading.Tasks;
using BagelGram.Core.Models;

namespace BagelGram.Core.Interfaces
{
    public interface ICommentRepository
    {
        Task<Comment> CreateCommentAsync(Comment comment);
        Task<IList<Comment>> GetImageComments(int imageId);
        Task<IList<Comment>> GetUserComments(int userId);
    }
}