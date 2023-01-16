using Blog.Data.Mappings;
using Blog.Entity.Entities;
using Microsoft.EntityFrameworkCore;
using System.Reflection;

namespace Blog.Data.Context
{
    public class AppDbContext : DbContext
    {
        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());
        }

        public AppDbContext(DbContextOptions options) : base(options)
        {

        }

        public DbSet<Article> Article { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Image> Images { get; set; }

    }
}
