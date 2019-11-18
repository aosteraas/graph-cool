using Microsoft.EntityFrameworkCore;

namespace BagelGram.Data
{
    public class BagelContext : DbContext
    {
        public BagelContext() { }

        public BagelContext(DbContextOptions<BagelContext> options) : base(options) { }
    }
}