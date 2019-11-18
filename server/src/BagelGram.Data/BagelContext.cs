using BagelGram.API.Models;
using Microsoft.EntityFrameworkCore;

namespace BagelGram.API.Data
{
    public class BagelContext : DbContext
    {
        public BagelContext() { }

        public BagelContext(DbContextOptions<BagelContext> options) : base(options) { }
    }
}