using Microsoft.EntityFrameworkCore;
using ModelsLib.Models;
using static System.Net.Mime.MediaTypeNames;
namespace DbApi.DbBookLib
{
    public class Db : DbContext
    {
        public Db(DbContextOptions<Db> options) : base(options) { }
        public DbSet<Author> Authors { get; set; }
        public DbSet<Book> Books { get; set; }
        public DbSet<BookFeedbacks> BookFeedbacks { get; set; }
        public DbSet<Comment> Comments { get; set; }
        public DbSet<GenresEnum> GenresEnum { get; set; }
        public DbSet<MarkEnum> MarkEnum { get; set; }
        public DbSet<Note> Notes { get; set; }
        public DbSet<User> Users { get; set; }
        public DbSet<UserBookInteraction> UserBookInteractions { get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Author>()
                .HasKey(a => a.AuthorId);
            modelBuilder.Entity<Author>()
                .Property(a => a.AuthorId)
                .HasColumnName("id_author");

            modelBuilder.Entity<Book>()
                .HasKey(a => a.BookId);
            modelBuilder.Entity<Book>()
                .Property(a => a.BookId)
                .HasColumnName("id_book");
            modelBuilder.Entity<Book>()
                .Property(a => a.NameGenres)
                .HasColumnName("nameGenres");
            modelBuilder.Entity<Book>()
                .Property(a => a.AuthorId)
                .HasColumnName("id_author");
            modelBuilder.Entity<Book>()
                .HasOne(i => i.Author)
                .WithMany(u => u.Books)
                .HasForeignKey(i => i.AuthorId);

            modelBuilder.Entity<BookFeedbacks>()
                .HasKey(a => a.InteractionId);
            modelBuilder.Entity<BookFeedbacks>()
                .Property(a => a.InteractionId)
                .HasColumnName("id_interaction");
            modelBuilder.Entity<BookFeedbacks>()
                .Property(a => a.FeedBackText)
                .HasColumnName("feedback_text");
            modelBuilder.Entity<BookFeedbacks>()
                .Property(a => a.Mark)
                .HasColumnName("mark");
            modelBuilder.Entity<BookFeedbacks>()
                .HasOne(i => i.MarkEnum)
                .WithMany(u => u.BookFeedbacks)
                .HasForeignKey(i => i.Mark);
            modelBuilder.Entity<BookFeedbacks>()
                .HasOne(i => i.UserBookInteraction)
                .WithMany(u => u.BookFeedbacks)
                .HasForeignKey(i => i.InteractionId);

            modelBuilder.Entity<Comment>()
                .HasKey(a => a.InteractionId);
            modelBuilder.Entity<Comment>()
                .Property(a => a.InteractionId)
                .HasColumnName("id_interaction");
            modelBuilder.Entity<Comment>()
                .Property(a => a.CommentText)
                .HasColumnName("comment_text");
            modelBuilder.Entity<Comment>()
                .HasOne(i => i.UserBookInteraction)
                .WithMany(u => u.Comments)
                .HasForeignKey(i => i.InteractionId);

            modelBuilder.Entity<GenresEnum>()
                .HasKey(a => a.Name);

            modelBuilder.Entity<MarkEnum>()
                .HasKey(a => a.Mark);

            modelBuilder.Entity<Note>()
                .HasKey(a => a.InteractionId);
            modelBuilder.Entity<Note>()
                .Property(a => a.InteractionId)
                .HasColumnName("id_interaction");
            modelBuilder.Entity<Note>()
                .Property(a => a.NoteText)
                .HasColumnName("note_text");
            modelBuilder.Entity<Note>()
                .HasOne(i => i.UserBookInteraction)
                .WithMany(u => u.Notes)
                .HasForeignKey(i => i.InteractionId);

            modelBuilder.Entity<User>()
                .HasKey(a => a.UserId);
            modelBuilder.Entity<User>()
                .Property(a => a.UserId)
                .HasColumnName("id_user");

            modelBuilder.Entity<UserBookInteraction>()
                .HasKey(a => a.InteractionId);
            modelBuilder.Entity<UserBookInteraction>()
                .Property(a => a.InteractionId)
                .HasColumnName("id_interaction");
            modelBuilder.Entity<UserBookInteraction>()
                .Property(a => a.UserId)
                .HasColumnName("id_user");
            modelBuilder.Entity<UserBookInteraction>()
                .Property(a => a.BookId)
                .HasColumnName("id_book");
            modelBuilder.Entity<UserBookInteraction>()
                .HasOne(a => a.User)
                .WithMany(u=>u.UserBookInteractions)
                .HasForeignKey(i=>i.UserId);
            modelBuilder.Entity<UserBookInteraction>()
                .HasOne(a => a.Book)
                .WithMany(u => u.UserBookInteraction)
                .HasForeignKey(i => i.BookId);
        }
    }
}
