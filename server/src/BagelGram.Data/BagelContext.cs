using BagelGram.Core.Models;
using Microsoft.EntityFrameworkCore;

namespace BagelGram.Data
{
    public class BagelContext : DbContext
    {
        public BagelContext() { }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Seed();
        }

        public BagelContext(DbContextOptions<BagelContext> options) : base(options) { }

        public DbSet<User> Users { get; set; }
        public DbSet<Image> Images { get; set; }
        public DbSet<Comment> Comments { get; set; }
        public DbSet<Like> Likes { get; set; }
    }
}