using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModelsLib.Models
{
    public class GenresEnum
    {
        public string Name { get; set; }
        public IEnumerable<Book> Books { get; set; }
    }
}
