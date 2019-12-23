using BagelGram.Core.Interfaces;
using GraphQL.Utilities;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;

namespace BagelGram.API.Services
{
    public class ContextServiceLocator
    {
        private readonly IHttpContextAccessor _httpContextAccessor;
        private readonly IWebHostEnvironment _env;
        public string ContentRootPath => _env.ContentRootPath;
        public IUserRepository UserRepository => _httpContextAccessor.HttpContext.RequestServices.GetRequiredService<IUserRepository>();
        public IImageRepository ImageRepository => _httpContextAccessor.HttpContext.RequestServices.GetRequiredService<IImageRepository>();
        public ICommentRepository CommentRepository => _httpContextAccessor.HttpContext.RequestServices.GetRequiredService<ICommentRepository>();
        public ILikeRepository LikeRepository => _httpContextAccessor.HttpContext.RequestServices.GetRequiredService<ILikeRepository>();

        public ContextServiceLocator(IHttpContextAccessor httpContextAccessor, IWebHostEnvironment env)
        {
            _httpContextAccessor = httpContextAccessor;
            _env = env;
        }
    }
}
