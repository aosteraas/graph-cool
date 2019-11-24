using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BagelGram.Core.Interfaces;
using BagelGram.Core.Models;
using Microsoft.EntityFrameworkCore;

namespace BagelGram.Data.Repositories
{
    public class LikeRepository : ILikeRepository
    {
        private readonly BagelContext _context;

        public LikeRepository(BagelContext context)
        {
            _context = context;
        }

        public async Task<int> GetLikesForImageAsync(int id) => await _context
            .Likes
            .AsNoTracking()
            .CountAsync(x => x.ImageId == id);


        public async Task<IList<Like>> GetUserLikes(int userId) => await _context
            .Likes
            .AsNoTracking()
            .Where(x => x.UserId == userId)
            .ToListAsync();


        public async Task<Like> ToggleAsync(Like like)
        {
            var existingLike = await _context.Likes
                .Where(x =>
                    x.UserId == like.UserId
                    && x.ImageId == like.ImageId
                )
                .FirstOrDefaultAsync();

            if (existingLike == null)
            {
                await _context.AddAsync(new Like
                {
                    ImageId = like.ImageId,
                    UserId = like.UserId,
                    Date = DateTime.Now
                });
            }
            else
            {
                _context.Remove(existingLike);
            }

            await _context.SaveChangesAsync();
            return like;
        }
    }
}