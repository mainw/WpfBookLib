using ModelsLib.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfBookLibApp.Repositories
{
    public interface IRepoBook
    {
        void Add(Book book);
        void Edit(Book book);
        void Delete(Book book);
        Book Get(int bookId);
        IEnumerable<Book> GetAll();
    }
}
