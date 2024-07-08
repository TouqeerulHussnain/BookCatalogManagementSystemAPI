using BookCatalogManagementSystemAPI.Core.Domain;
using Microsoft.EntityFrameworkCore;

namespace BookCatalogManagementSystemAPI.Core.Repository
{
    public class BookCatalogDbContext:DbContext
    {
        private readonly DbContextOptions<BookCatalogDbContext> options;

        public BookCatalogDbContext(DbContextOptions<BookCatalogDbContext> options):base(options) 
        {
            this.options = options;
        }

        public DbSet<Book>  Books { get; set; }
        public DbSet<Chapter> Chapters { get; set; }
        public DbSet<Tag> Tags { get; set; }



    }
}
