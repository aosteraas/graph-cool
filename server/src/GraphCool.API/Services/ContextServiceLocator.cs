using GraphCool.API.Interfaces;
using GraphQL.Utilities;
using Microsoft.AspNetCore.Http;

namespace GraphCool.API.Services
{
    public class ContextServiceLocator
    {
        public IPersonService PersonService => _httpContextAccessor.HttpContext.RequestServices.GetRequiredService<IPersonService>();

        private readonly IHttpContextAccessor _httpContextAccessor;

        public ContextServiceLocator(IHttpContextAccessor httpContextAccessor)
        {
            _httpContextAccessor = httpContextAccessor;
        }
    }
}