using ModelsLib.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfBookLibApp.Repositories
{
    public interface IRepoComment
    {
        void Add(Comment book);
        void Edit(Comment book);
        void Delete(Comment book);
        Comment Get(int commentId);
        IEnumerable<Comment> GetAll();
    }
}
