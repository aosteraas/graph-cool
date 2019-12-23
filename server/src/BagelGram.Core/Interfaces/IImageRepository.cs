using System.Collections.Generic;
using System.Threading.Tasks;
using BagelGram.Core.Models;

namespace BagelGram.Core.Interfaces
{
    public interface IImageRepository
    {
        Task<Image> CreateImageAsync(Image image);
        Task<Image> GetImageAsync(int id);
        Task<IList<Image>> GetImagesAsync();
        Task<IList<Image>> GetUserImages(int userId);

        Task<Image> AddImageAsync(string path, string imageData, string caption);
    }
}