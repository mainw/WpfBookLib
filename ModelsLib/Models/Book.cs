using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModelsLib.Models
{
    public class Book
    {
        public long BookId { get; set; }
        public string NameGenres { get; set; }
        public long AuthorId { get; set; }
        public string Name { get; set; }
        public DateTime? Date { get; set; }
        public string Description { get; set; }
        public Author Author { get; set; }
        public IEnumerable<UserBookInteraction> UserBookInteraction { get; set; }
    }
}
