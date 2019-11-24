using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BagelGram.Core.Interfaces;
using BagelGram.Core.Models;
using Microsoft.EntityFrameworkCore;

namespace BagelGram.Data.Repositories
{
    public class ImageRepository : IImageRepository
    {
        private readonly BagelContext _context;

        public ImageRepository(BagelContext context)
        {
            _context = context;
        }

        public async Task<Image> CreateImageAsync(Image image)
        {
            var newImage = new Image
            {
                UserId = image.UserId,
                Source = image.Source
            };
            await _context.AddAsync(newImage);
            await _context.SaveChangesAsync();
            return newImage;
        }

        public async Task<Image> GetImageAsync(int id) => await _context
            .Images
            .AsNoTracking()
            .FirstOrDefaultAsync(x => x.Id == id);

        public async Task<IList<Image>> GetImagesAsync() => await _context
            .Images
            .AsNoTracking()
            .Include(x => x.Likes)
            .Include(x => x.Comments)
            .ToListAsync();

        public async Task<IList<Image>> GetUserImages(int userId) => await _context
            .Images
            .AsNoTracking()
            .Where(x => x.UserId == userId)
            .ToListAsync();
    }
}