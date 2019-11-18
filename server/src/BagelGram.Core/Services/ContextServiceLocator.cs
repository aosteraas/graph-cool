using BagelGram.API.Interfaces;
using GraphQL.Utilities;
using Microsoft.AspNetCore.Http;

namespace BagelGram.API.Services
{
    public class ContextServiceLocator
    {
        private readonly IHttpContextAccessor _httpContextAccessor;

        public ContextServiceLocator(IHttpContextAccessor httpContextAccessor)
        {
            _httpContextAccessor = httpContextAccessor;
        }
    }
}
