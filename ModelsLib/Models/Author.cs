using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModelsLib.Models
{
    public class Author
    {
        public long AuthorId { get; set; }
        public string Fullname { get; set; }
        public IEnumerable<Book> Books { get; set; }
    }
}
