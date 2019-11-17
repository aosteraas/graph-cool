using GraphCool.API.Models;
using Microsoft.EntityFrameworkCore;

namespace GraphCool.API.Data
{
    public class CoolContext : DbContext
    {
        public DbSet<Person> People { get; set; }
        public DbSet<Eaten> Eaten { get; set; }
        public DbSet<Meal> Meals { get; set; }

        public CoolContext() { }

        public CoolContext(DbContextOptions<CoolContext> options) : base(options) { }
    }
}