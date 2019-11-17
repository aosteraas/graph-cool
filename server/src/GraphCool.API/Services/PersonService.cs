using System.Collections.Generic;
using System.Threading.Tasks;
using GraphCool.API.Data;
using GraphCool.API.Interfaces;
using GraphCool.API.Models;
using Microsoft.EntityFrameworkCore;

namespace GraphCool.API.Services
{
    public class PersonService : IPersonService
    {
        private readonly CoolContext _context;

        public PersonService(CoolContext context)
        {
            _context = context;
        }

        public async Task<Person> GetAsync(int personId) =>
            await _context
                .People
                .FirstOrDefaultAsync(x => x.Id == personId);
    }
}