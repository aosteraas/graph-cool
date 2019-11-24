using System.Collections.Generic;
using System.Threading.Tasks;
using BagelGram.Core.Models;

namespace BagelGram.Core.Interfaces
{
    public interface ILikeRepository
    {
        Task<Like> ToggleAsync(Like like);
        Task<int> GetLikesForImageAsync(int id);
        Task<IList<Like>> GetUserLikes(int userId);
    }
}