using System.Collections.Generic;
using System.Threading.Tasks;
using BagelGram.Core.Models;

namespace BagelGram.Core.Interfaces
{
    public interface IUserRepository
    {
        Task<User> GetUserAsync(int id);
        Task<IList<User>> GetUsersAsync();
        Task<User> CreateUserAsync(User user);
    }
}