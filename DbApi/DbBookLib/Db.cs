using Microsoft.EntityFrameworkCore;
using ModelsLib.Models;
namespace DbApi.DbBookLib
{
    public class Db : DbContext
    {
        public Db() { }
        public DbSet<Author> Authors { get; set; }
        public DbSet<Book> Books { get; set; }
        public DbSet<BookFeedbacks> BookFeedbacks { get; set; }
        public DbSet<Comment> Comments { get; set; }
        public DbSet<GenresEnum> GenresEnum { get; set; }
        public DbSet<MarkEnum> MarkEnum { get; set; }
        public DbSet<Note> Notes { get; set; }
        public DbSet<User> Users { get; set; }
        public DbSet<UserBookInteraction> UserBookInteractions { get; set; }
    }
}
