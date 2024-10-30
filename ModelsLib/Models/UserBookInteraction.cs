using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModelsLib.Models
{
    public class UserBookInteraction
    {
        public long InteractionId { get; set; }
        public long BookId { get; set; }
        public long UserId { get; set; }
        public User User { get; set; }
        public Book Book { get; set; }
        public IEnumerable<Comment> Comments { get; set; }
        public IEnumerable<Note> Notes { get; set; }
        public IEnumerable<BookFeedbacks> BookFeedbacks { get; set; }
    }
}
