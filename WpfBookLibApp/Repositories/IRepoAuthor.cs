using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Media.Animation;
using ModelsLib.Models;
namespace WpfBookLibApp.Repositories
{
    public interface IRepoAuthor
    {
        void Add(Author author);
        void Edit(Author author);
        void Delete(Author author);
        Author Get(int authorId);
        IEnumerable<Author> GetAll();
    }
}
