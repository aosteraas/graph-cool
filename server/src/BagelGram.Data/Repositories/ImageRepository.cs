using System;
using System.Collections.Generic;
using System.IO;
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

        public async Task<Image> AddImageAsync(string path, string imageData, string caption)
        {
            var source = SaveImage(path, imageData);
            var image = new Image
            {
                Source = source,
                Caption = caption,
                UserId = 1,
                Uploaded = DateTime.Now
            };
            await _context.AddAsync(image);
            await _context.SaveChangesAsync();
            return image;
        }

        public string SaveImage(string path, string imageData)
        {
            var base64String = imageData.Split(',');
            var bytes = Convert.FromBase64String(base64String[1]);
            var fileName = Guid.NewGuid();
            var filePath = $"/uploads/{fileName}.jpg";
            using (var imageFile = new FileStream($"{path}{filePath}", FileMode.Create))
            {
                imageFile.Write(bytes, 0, bytes.Length);
                imageFile.Flush();
            }
            return filePath;
        }

        public async Task<Image> CreateImageAsync(Image image)
        {
            var newImage = new Image
            {
                UserId = image.UserId,
                Source = image.Source,
                Caption = image.Caption,
                Uploaded = DateTime.Now
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
            .OrderByDescending(x => x.Uploaded)
            .ToListAsync();

        public async Task<IList<Image>> GetUserImages(int userId) => await _context
            .Images
            .AsNoTracking()
            .Where(x => x.UserId == userId)
            .ToListAsync();
    }
}