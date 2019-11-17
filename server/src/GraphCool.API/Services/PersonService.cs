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

        public async Task<Person> CreateAsync(Person person)
        {
            var p = new Person
            {
                Name = person.Name,
                BirthDate = person.BirthDate
            };
            await _context.AddAsync(p);
            await _context.SaveChangesAsync();
            return p;
        }

        public async Task<List<Person>> GetAllAsync() =>
            await _context
                .People
                .ToListAsync();

        public async Task<Person> GetAsync(int personId) =>
            await _context
                .People
                .FirstOrDefaultAsync(x => x.Id == personId);
    }
}