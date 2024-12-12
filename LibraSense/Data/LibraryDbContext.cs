using LibraSense.Models;
using Microsoft.EntityFrameworkCore;

namespace LibraSense.Data
{
    public class LibraryDbContext: DbContext
    {
        public DbSet<User> Users { get; set; }
        public DbSet<Book> Books { get; set; }
        public DbSet<BorrowRecord> BorrowRecords { get; set; }

        public LibraryDbContext(DbContextOptions<LibraryDbContext> options) : base(options) { }
    }
}
