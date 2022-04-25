using Microsoft.EntityFrameworkCore;
using Thoughtful.Domain.Model;

namespace Thoughtful.Dal
{
    public class ThoughtfulDbContext : DbContext
    {
        public ThoughtfulDbContext(DbContextOptions options) : base(options)
        {
            
        }

        public DbSet<Article> Articles { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Author> Authors { get; set; }
        public DbSet<Blog> Blogs { get; set; }

    }
}
