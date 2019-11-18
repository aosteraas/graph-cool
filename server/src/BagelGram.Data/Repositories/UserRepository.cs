using System.Collections.Generic;
using System.Threading.Tasks;
using BagelGram.Core.Interfaces;
using BagelGram.Core.Models;
using Microsoft.EntityFrameworkCore;

namespace BagelGram.Data.Repositories
{
    public class UserRepository : IUserRepository
    {
        private readonly BagelContext _context;

        public UserRepository(BagelContext context)
        {
            _context = context;
        }

        public async Task<User> CreateUserAsync(User user)
        {
            var newUser = new User
            {
                UserName = user.UserName,
                BirthDate = user.BirthDate
            };
            await _context.AddAsync(newUser);
            await _context.SaveChangesAsync();
            return newUser;
        }

        public async Task<User> GetUserAsync(int id) => await _context
            .Users
            .AsNoTracking()
            .FirstOrDefaultAsync(x => x.Id == id);

        public async Task<IList<User>> GetUsersAsync() => await _context
            .Users
            .AsNoTracking()
            .ToListAsync();
    }
}