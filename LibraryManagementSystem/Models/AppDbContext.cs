using Microsoft.EntityFrameworkCore;

namespace LibraryManagementSystem.Models
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions options) : base(options)
        {
        }

        public DbSet<Book> Books { get; set; }
        public DbSet<Author> Authors { get; set; }
        public DbSet<Publisher> Publishers { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Member> Members { get; set; }
        public DbSet<BorrowRecord> BorrowRecords { get; set; }
        public DbSet<Penalty> Penalties { get; set; }
    }
}
